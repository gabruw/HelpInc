$(document).ready(function () {
    new Glide('#Glide-container', {
        type: 'carousel',
        focusAt: 'center',
        gap: 10,
        perView: 1,
        startAt: 0,
        autoplay: 3000,
        hoverpause: true,
        rewind: true,
        rewindDuration: 8000,
        animationDuration: 600,
        animationTimingFunc: 'ease-out',
        activeNav: 'glide__bullet--active',
    }).mount();


    let divBullet = document.querySelector(".glide__bullets");
    let slides = document.querySelector(".glide__slides");
    let cont = 0;

    slides.childNodes.forEach((value) => {
        if (value.className === "glide__slide" || cont === 0) {
            cont++;

            const button = document.createElement('button');
            button.setAttribute('class', 'glide__bullet');
            button.setAttribute('data-glide-dir', `=${cont}`);

            divBullet.appendChild(button);
        }
    });
});