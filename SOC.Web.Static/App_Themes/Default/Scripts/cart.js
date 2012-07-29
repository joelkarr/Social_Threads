jQuery(document).ready(function($) {
	

		// Ajax add to cart
		$('.add_to_cart_button').live('click', function() {
			
			// AJAX add to cart request
			var $thisbutton = $(this);
			
			if ($thisbutton.is('.product_type_simple, .product_type_downloadable, .product_type_virtual')) {
				
				if (!$thisbutton.attr('data-product_id')) return true;
				
				$thisbutton.removeClass('added');
				$thisbutton.addClass('loading');
				
				var data = {
					action: 		'add_to_cart',
					product_id: 	$thisbutton.attr('data-product_id')

				};
				
				// Trigger event
				$('body').trigger('adding_to_cart');
				
				// Ajax action
				$.post( '/cart/add', data, function(response) {
					
					var this_page = window.location.toString();
					
					this_page = this_page.split("?")[0];
					
					$thisbutton.removeClass('loading');
	
					// Get response
					data = $.parseJSON( response );
					
					if (data.error && data.product_url) {
						window.location = data.product_url;
						return;
					}
					
					fragments = data;
	
					// Block fragments class
					if (fragments) {
						$.each(fragments, function(key, value) {
							$(key).addClass('updating');
						});
					}
					
					// Block widgets and fragments
					$('.widget_shopping_cart, .shop_table.cart, .updating, .cart_totals').fadeTo('400', '0.6').block({message: null, overlayCSS: {background: 'transparent url(' + woocommerce_params.plugin_url + '/assets/images/ajax-loader.gif) no-repeat center', opacity: 0.6}});
					
					// Changes button classes
					$thisbutton.addClass('added');
	
					// Cart widget load
					if ($('.widget_shopping_cart').size()>0) {
						$('.widget_shopping_cart:eq(0)').load( this_page + ' .widget_shopping_cart:eq(0) > *', function() {
							
							// Replace fragments
							if (fragments) {
								$.each(fragments, function(key, value) {
									$(key).replaceWith(value);
								});
							}
							
							// Unblock
							$('.widget_shopping_cart, .updating').css('opacity', '1').unblock();
							
							$('body').trigger('cart_widget_refreshed');
						} );
					} else {
						// Replace fragments
						if (fragments) {
							$.each(fragments, function(key, value) {
								$(key).replaceWith(value);
							});
						}
						
						// Unblock
						$('.widget_shopping_cart, .updating').css('opacity', '1').unblock();
					}
					
					// Cart page elements
					$('.shop_table.cart').load( this_page + ' .shop_table.cart:eq(0) > *', function() {
						
						$("div.quantity:not(.buttons_added), td.quantity:not(.buttons_added)").addClass('buttons_added').append('<input type="button" value="+" id="add1" class="plus" />').prepend('<input type="button" value="-" id="minus1" class="minus" />');
						
						$('.shop_table.cart').css('opacity', '1').unblock();
						
						$('body').trigger('cart_page_refreshed');
					});
					
					$('.cart_totals').load( this_page + ' .cart_totals:eq(0) > *', function() {
						$('.cart_totals').css('opacity', '1').unblock();
					});
					
					// Trigger event so themes can refresh other areas
					$('body').trigger('added_to_cart');
			
				});
				
				return false;
			
			} else {
				return true;
			}
			
		});
	

	
	// Orderby
	$('select.orderby').change(function(){
		$(this).closest('form').submit();
	});
	
	
	// Quantity buttons
	$("div.quantity:not(.buttons_added), td.quantity:not(.buttons_added)").addClass('buttons_added').append('<input type="button" value="+" id="add1" class="plus" />').prepend('<input type="button" value="-" id="minus1" class="minus" />');
	
	// Target quantity inputs on product pages
	$("input.qty:not(.product-quantity input.qty)").each(function(){
		
		var min = parseInt($(this).attr('data-min'));
		
		if (min && min > 1 && parseInt($(this).val()) < min) {
			
			$(this).val(min);
			
		}
		
	});
	
	$(".plus").live('click', function() {
	    var currentVal = parseInt($(this).prev(".qty").val());
	    if (!currentVal || currentVal=="" || currentVal == "NaN") currentVal = 0;
	    
	    $qty = $(this).prev(".qty");
	    
	    var max = parseInt($qty.attr('data-max'));
	    if (max=="" || max == "NaN") max = '';
	    
	    if (max && (max==currentVal || currentVal>max)) {
	    	$qty.val(max); 
	    } else {
	    	$qty.val(currentVal + 1); 
	    }
	    
	    $qty.trigger('change');
	});
	
	$(".minus").live('click', function() {
		var currentVal = parseInt($(this).next(".qty").val());
	    if (!currentVal || currentVal=="" || currentVal == "NaN") currentVal = 0;
	    
	    $qty = $(this).next(".qty");
	    
	    var min = parseInt($qty.attr('data-min'));
	    if (min=="" || min == "NaN") min = 0;
	    
	    if (min && (min==currentVal || currentVal<min)) {
	    	$qty.val(min); 
	    } else if (currentVal > 0) {
	    	$qty.val(currentVal - 1);
	    }
	    
	    $qty.trigger('change');
	});
	

	

});