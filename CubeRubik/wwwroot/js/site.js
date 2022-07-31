// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    console.log("ready!");
    $('.top-side .layer1-top').addClass('orange');
    $('.top-side .layer2-top').addClass('orange');
    $('.top-side .layer3-top').addClass('orange');

    $('.front-side .layer3-front').addClass('yellow');
    $('.front-side .layer2-front').addClass('yellow');
    $('.front-side .layer1-front').addClass('yellow');

    $('.bottom-side .layer3-bottom').addClass('red');
    $('.bottom-side .layer2-bottom').addClass('red');
    $('.bottom-side .layer1-bottom').addClass('red');

    $('.left-side .layer3-left').addClass('blue');
    $('.left-side .layer2-left').addClass('blue');
    $('.left-side .layer1-left').addClass('blue');

    $('.right-side .layer3-right').addClass('green');
    $('.right-side .layer2-right').addClass('green');
    $('.right-side .layer1-right').addClass('green');

    ClickMixButton();
});

function ClickMixButton() {
    $(".button").click(function () {
        $.ajax({
            url: "Home/Mix",
            context: document.body
        }).done(function () {
            $(this).addClass("done");
        });
    });
}