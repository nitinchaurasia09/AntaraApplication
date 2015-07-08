$(window).keydown(function(e) {
    

    var $targetElement="";
    //down
    if (e.keyCode == 40) {
        e.preventDefault();   
            $targetElement = $('.activesumit').next('section'); 
    }
    //up
    else if (e.keyCode == 38) {   
        e.preventDefault();     
        $targetElement = $('.activesumit').prev('section');     
    }

    if (!$targetElement.length) {return;}
    $('.activesumit').removeClass('activesumit');
    $targetElement.addClass('activesumit');

    var navHeight= $('header').height();
    //alert(navHeight);   
     
    $('html, body').clearQueue().animate({scrollTop: ($targetElement.offset().top-navHeight) }, 1000);
});


//jQuery for page scrolling feature - requires jQuery Easing plugin
	$(function() {
	
		$('.scroll  a').bind('click', function(event) {

            var navHeight= $('header').height();
				var $anchor = $(this);
				$('html, body').stop().animate({
					scrollTop: ($($anchor.attr('href')).offset().top-navHeight)
				}, 1000, 'easeInOutExpo');
				event.preventDefault();
		});

        $('.leftSection  a').bind('click', function(event) {

            var navHeight= $('header').height();
                var $anchor = $(this);
                $('html, body').stop().animate({
                    scrollTop: ($($anchor.attr('href')).offset().top-navHeight)
                }, 1000, 'easeInOutExpo');
                event.preventDefault();
        });

});






