// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    console.log("ready!");
    $('.top-side .layer1-top').addClass('orange');
    $('.top-side .layer2-top').addClass('orange');
    $('.top-side .layer3-top').addClass('orange');

    //$('.front-side .layer3-front').addClass('yellow');
    //$('.front-side .layer2-front').addClass('yellow');
    //$('.front-side .layer1-front').addClass('yellow');

    //$('.bottom-side .layer3-bottom').addClass('red');
    //$('.bottom-side .layer2-bottom').addClass('red');
    //$('.bottom-side .layer1-bottom').addClass('red');

    $('.left-side .layer3-left').addClass('blue');
    $('.left-side .layer2-left').addClass('blue');
    $('.left-side .layer1-left').addClass('blue');

    $('.right-side .layer3-right').addClass('green');
    $('.right-side .layer2-right').addClass('green');
    $('.right-side .layer1-right').addClass('green');

    ClickMixButton();
});

let RED = 1;
let YELLOW = 2;
let ORANGE = 3;
let WHITE = 4;
let BLUE = 5;
let GREEN = 6;

function ClickMixButton() {
    $(".button").click(function () {
        $.ajax({
            url: "Home/Mix",
            context: document.body
        }).done(function (data) {
            
            //Side 1
            for (let i = 0; i < data.sideOne.hLayer3.cells.length; i++) {
                switch (data.sideOne.hLayer3.cells[i]) {
                    case RED: $($('.layer3-one td')[i]).addClass('red'); break;
                    case YELLOW: $($('.layer3-one td')[i]).addClass('yellow'); break;
                    case ORANGE: $($('.layer3-one td')[i]).addClass('orange'); break;
                    case WHITE: $($('.layer3-one td')[i]).addClass(''); break;
                    case BLUE: $($('.layer3-one td')[i]).addClass('blue'); break;
                    case GREEN: $($('.layer3-one td')[i]).addClass('green'); break;
                }
            }
            for (let i = 0; i < data.sideOne.hLayer2.cells.length; i++) {
                switch (data.sideOne.hLayer2.cells[i]) {
                    case RED: $($('.layer2-one td')[i]).addClass('red'); break;
                    case YELLOW: $($('.layer2-one td')[i]).addClass('yellow'); break;
                    case ORANGE: $($('.layer2-one td')[i]).addClass('orange'); break;
                    case WHITE: $($('.layer2-one td')[i]).addClass(''); break;
                    case BLUE: $($('.layer2-one td')[i]).addClass('blue'); break;
                    case GREEN: $($('.layer2-one td')[i]).addClass('green'); break;
                }
            }
            for (let i = 0; i < data.sideOne.hLayer1.cells.length; i++) {
                switch (data.sideOne.hLayer1.cells[i]) {
                    case RED: $($('.layer1-one td')[i]).addClass('red'); break;
                    case YELLOW: $($('.layer1-one td')[i]).addClass('yellow'); break;
                    case ORANGE: $($('.layer1-one td')[i]).addClass('orange'); break;
                    case WHITE: $($('.layer1-one td')[i]).addClass(''); break;
                    case BLUE: $($('.layer1-one td')[i]).addClass('blue'); break;
                    case GREEN: $($('.layer1-one td')[i]).addClass('green'); break;
                }
            }
            //Side 2
            for (let i = 0; i < data.sideTwo.hLayer3.cells.length; i++) {
                switch (data.sideTwo.hLayer3.cells[i]) {
                    case RED: $($('.layer3-two td')[i]).addClass('red'); break;
                    case YELLOW: $($('.layer3-two td')[i]).addClass('yellow'); break;
                    case ORANGE: $($('.layer3-two td')[i]).addClass('orange'); break;
                    case WHITE: $($('.layer3-two td')[i]).addClass(''); break;
                    case BLUE: $($('.layer3-two td')[i]).addClass('blue'); break;
                    case GREEN: $($('.layer3-two td')[i]).addClass('green'); break;
                }
            }
            for (let i = 0; i < data.sideTwo.hLayer2.cells.length; i++) {
                switch (data.sideTwo.hLayer2.cells[i]) {
                    case RED: $($('.layer2-two td')[i]).addClass('red'); break;
                    case YELLOW: $($('.layer2-two td')[i]).addClass('yellow'); break;
                    case ORANGE: $($('.layer2-two td')[i]).addClass('orange'); break;
                    case WHITE: $($('.layer2-two td')[i]).addClass(''); break;
                    case BLUE: $($('.layer2-two td')[i]).addClass('blue'); break;
                    case GREEN: $($('.layer2-two td')[i]).addClass('green'); break;
                }
            }
            for (let i = 0; i < data.sideTwo.hLayer1.cells.length; i++) {
                switch (data.sideTwo.hLayer1.cells[i]) {
                    case RED: $($('.layer1-two td')[i]).addClass('red'); break;
                    case YELLOW: $($('.layer1-two td')[i]).addClass('yellow'); break;
                    case ORANGE: $($('.layer1-two td')[i]).addClass('orange'); break;
                    case WHITE: $($('.layer1-two td')[i]).addClass(''); break;
                    case BLUE: $($('.layer1-two td')[i]).addClass('blue'); break;
                    case GREEN: $($('.layer1-two td')[i]).addClass('green'); break;
                }
            }
            
        });
    });
}