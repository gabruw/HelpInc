$(document).ready(function () {
    randomBackgroundImage = () => {
        let vectorImage = ["url('../images/Login/background-login-1.jpg')",
            "url('../images/Login/background-login-2.jpg')",
            "url('../images/Login/background-login-3.jpg')",
            "url('../images/Login/background-login-4.jpg')",
            "url('../images/Login/background-login-5.jpg')",
            "url('../images/Login/background-login-6.jpg')"
        ];

        const imageRandom = Math.floor(Math.random() * vectorImage.length);
        $("body").css("background-image", vectorImage[imageRandom]);
    };
});

$('#Estado')
    .dropdown();

$('#Cidade')
    .dropdown();

$('#tela-registro .menu .item').tab();