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
});