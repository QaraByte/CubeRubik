// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    console.log("ready!");
    //$('.top-side .layer1-top').addClass('orange');
    //$('.top-side .layer2-top').addClass('orange');
    //$('.top-side .layer3-top').addClass('orange');

    //$('.front-side .layer3-front').addClass('yellow');
    //$('.front-side .layer2-front').addClass('yellow');
    //$('.front-side .layer1-front').addClass('yellow');

    //$('.bottom-side .layer3-bottom').addClass('red');
    //$('.bottom-side .layer2-bottom').addClass('red');
    //$('.bottom-side .layer1-bottom').addClass('red');

    //$('.left-side .layer3-left').addClass('blue');
    //$('.left-side .layer2-left').addClass('blue');
    //$('.left-side .layer1-left').addClass('blue');

    //$('.right-side .layer3-right').addClass('green');
    //$('.right-side .layer2-right').addClass('green');
    //$('.right-side .layer1-right').addClass('green');

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
                SetClassColor(data.sideTwo.hLayer3.cells[i], i, '.layer3-two td');
            }
            for (let i = 0; i < data.sideTwo.hLayer2.cells.length; i++) {
                SetClassColor(data.sideTwo.hLayer2.cells[i], i, '.layer2-two td');
            }
            for (let i = 0; i < data.sideTwo.hLayer1.cells.length; i++) {
                SetClassColor(data.sideTwo.hLayer1.cells[i], i, '.layer1-two td');
            }
            //Side 3
            for (let i = 0; i < data.sideThree.hLayer3.cells.length; i++) {
                SetClassColor(data.sideThree.hLayer3.cells[i], i, '.layer3-three td');
            }
            for (let i = 0; i < data.sideThree.hLayer2.cells.length; i++) {
                SetClassColor(data.sideThree.hLayer2.cells[i], i, '.layer2-three td');
            }
            for (let i = 0; i < data.sideThree.hLayer1.cells.length; i++) {
                SetClassColor(data.sideThree.hLayer1.cells[i], i, '.layer1-three td');
            }
            //Side 4
            for (let i = 0; i < data.sideFour.hLayer3.cells.length; i++) {
                SetClassColor(data.sideFour.hLayer3.cells[i], i, '.layer3-four td');
            }
            for (let i = 0; i < data.sideFour.hLayer2.cells.length; i++) {
                SetClassColor(data.sideFour.hLayer2.cells[i], i, '.layer2-four td');
            }
            for (let i = 0; i < data.sideFour.hLayer1.cells.length; i++) {
                SetClassColor(data.sideFour.hLayer1.cells[i], i, '.layer1-four td');
            }
            //Side 5
            for (let i = 0; i < data.sideFive.hLayer3.cells.length; i++) {
                SetClassColor(data.sideFive.hLayer3.cells[i], i, '.layer3-five td');
            }
            for (let i = 0; i < data.sideFive.hLayer2.cells.length; i++) {
                SetClassColor(data.sideFive.hLayer2.cells[i], i, '.layer2-five td');
            }
            for (let i = 0; i < data.sideFive.hLayer1.cells.length; i++) {
                SetClassColor(data.sideFive.hLayer1.cells[i], i, '.layer1-five td');
            }
            //Side 6
            for (let i = 0; i < data.sideSix.hLayer3.cells.length; i++) {
                SetClassColor(data.sideSix.hLayer3.cells[i], i, '.layer3-six td');
            }
            for (let i = 0; i < data.sideSix.hLayer2.cells.length; i++) {
                SetClassColor(data.sideSix.hLayer2.cells[i], i, '.layer2-six td');
            }
            for (let i = 0; i < data.sideSix.hLayer1.cells.length; i++) {
                SetClassColor(data.sideSix.hLayer1.cells[i], i, '.layer1-six td');
            }
        });
    });
}

function SetClassColor(color, cell, class1) {
    switch (color) {
        case RED: $($(class1)[cell]).addClass('red'); break;
        case YELLOW: $($(class1)[cell]).addClass('yellow'); break;
        case ORANGE: $($(class1)[cell]).addClass('orange'); break;
        case WHITE: $($(class1)[cell]).addClass(''); break;
        case BLUE: $($(class1)[cell]).addClass('blue'); break;
        case GREEN: $($(class1)[cell]).addClass('green'); break;
    }
}