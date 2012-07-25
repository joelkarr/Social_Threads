/*-----------------------------------------------------------------------------------*/
/* GENERAL SCRIPTS */
/*-----------------------------------------------------------------------------------*/


//jQuery(window).load(function() {
//	
//	if ( woo_localized_data.slider_autoplay == 'true' ) {
//		woo_localized_data.slider_autoplay = true;
//	} else {
//		woo_localized_data.slider_autoplay = false;
//	}
//	
//	if ( woo_localized_data.slider_hover == 'true' ) {
//		woo_localized_data.slider_hover = true;
//	} else {
//		woo_localized_data.slider_hover = false;
//	}
//	
//	jQuery( '#featured .flexslider' ).flexslider({
//		controlsContainer: "#featured",
//		directionNav: false, 
//		slideDirection: woo_localized_data.slider_sliding_direction,
//   		animation: woo_localized_data.slider_effect,
//   		slideshow: woo_localized_data.slider_autoplay,
//   		pauseOnHover: woo_localized_data.slider_hover,
//   		slideshowSpeed: woo_localized_data.slider_speed, 
//   		animationDuration: woo_localized_data.slider_animation_speed
//	});
//	jQuery( '#popular .flexslider' ).flexslider({
//		controlsContainer: "#popular",
//		directionNav: false, 
//		slideDirection: woo_localized_data.slider_sliding_direction,
//   		animation: woo_localized_data.slider_effect,
//   		slideshow: woo_localized_data.slider_autoplay,
//   		pauseOnHover: woo_localized_data.slider_hover,
//   		slideshowSpeed: woo_localized_data.slider_speed, 
//   		animationDuration: woo_localized_data.slider_animation_speed
//	});
//	jQuery( '#promo .flexslider' ).flexslider({
//		controlNav: false,
//		controlsContainer: '#promo', 
//		slideDirection: woo_localized_data.slider_sliding_direction,
//   		animation: woo_localized_data.slider_effect,
//   		slideshow: woo_localized_data.slider_autoplay,
//   		pauseOnHover: woo_localized_data.slider_hover,
//   		slideshowSpeed: woo_localized_data.slider_speed, 
//   		animationDuration: woo_localized_data.slider_animation_speed
//	});
//});

jQuery(document).ready(function(){

// Last item classes for IE
jQuery('#popular li div:nth-child(3n)').addClass('last');

/*-----------------------------------------------------------------------------------*/
/* Add rel="lightbox" to image links if the lightbox is enabled */
/*-----------------------------------------------------------------------------------*/

//if ( jQuery( 'body' ).hasClass( 'has-lightbox' ) && ! jQuery( 'body' ).hasClass( 'portfolio-component' ) ) {
//	jQuery( 'a[href$=".jpg"], a[href$=".jpeg"], a[href$=".gif"], a[href$=".png"]' ).each( function () {
//		var imageTitle = '';
//		if ( jQuery( this ).next().hasClass( 'wp-caption-text' ) ) {
//			imageTitle = jQuery( this ).next().text();
//		}
//		
//		jQuery( this ).attr( 'rel', 'lightbox' ).attr( 'title', imageTitle );
//	});
//}

//	jQuery( 'a[rel^="lightbox"]' ).prettyPhoto();

	// Fire Uniform js
	jQuery("select.orderby, .variations select, input[type=radio]").uniform();

	// Table alt row styling
	jQuery( '.entry table tr:odd' ).addClass( 'alt-table-row' );
	
	// FitVids - Responsive Videos
	jQuery( ".post, .widget" ).fitVids();
	
	// Superfish for nav dropdowns
	jQuery( 'ul.nav').superfish({
		delay: 200,
		animation: {opacity:'show', height:'show'},
		speed: 'fast',
		dropShadows: false
	});
	
	// Responsive Navigation (switch top drop down for select)
	jQuery('ul#top-nav').mobileMenu({
		switchWidth: 767,                   //width (in px to switch at)
		topOptionText: 'Select a page',     //first option text
		indentString: '&nbsp;&nbsp;&nbsp;'  //string for indenting nested items
	});
	
});