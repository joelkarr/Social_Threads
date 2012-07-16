$(document).ready(function(){
	var slider = $('#slidertron');

	if (slider.length > 0)
	{
		slider.slidertron({
			viewerSelector: '.viewer',
			reelSelector: '.viewer .reel',
			slidesSelector: '.viewer .reel .slide',
			slideLinkSelector: '.link',
			advanceDelay: 4000,
			speed: 900,
			clickToNav: true,
			viewerOffset: -10
		});
		
		$('#slidertron .shadow-left').css('cursor', 'pointer').click(function() { slider.trigger('previousSlide'); });
		$('#slidertron .shadow-right').css('cursor', 'pointer').click(function() { slider.trigger('nextSlide'); });
	}
});