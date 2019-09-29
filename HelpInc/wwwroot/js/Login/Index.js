$(document).ready(function () {
    randomBackgroundImage = () => {
        const height = window.innerHeight;
        const width = window.innerWidth;
        let vectorImage = [];

        if (width >= height) {
            vectorImage = ["url('../images/Login/background-login-1.jpg')",
                "url('../images/Login/background-login-2.jpg')",
                "url('../images/Login/background-login-3.jpg')",
                "url('../images/Login/background-login-4.jpg')",
                "url('../images/Login/background-login-5.jpg')",
                "url('../images/Login/background-login-6.jpg')"
            ];
        } else {
            vectorImage = ["url('../images/Login/background-login-1.jpg')",
                "url('../images/Login/background-login-2.jpg')",
                "url('../images/Login/background-login-3.jpg')",
                "url('../images/Login/background-login-4.jpg')",
                "url('../images/Login/background-login-5.jpg')",
                "url('../images/Login/background-login-6.jpg')"
            ];
        };

        const imageRandom = Math.floor(Math.random() * vectorImage.length);
        $("body").css("background-image", vectorImage[imageRandom]);
    };
});