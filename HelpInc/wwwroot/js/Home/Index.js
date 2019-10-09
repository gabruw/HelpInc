$(document).ready(function () {
    var resizePopup = () => {
        $('.ui.popup').css('max-height', $(window).height());
    };

    $(window).resize((e) => {
        resizePopup();
    });

    $('#Login-popup').popup({
        hoverable: true,
        lastResort: 'bottom left',
        onShow: () => {
            resizePopup();
        },
        delay: {
            show: 300,
            hide: 500
        }
    });
});