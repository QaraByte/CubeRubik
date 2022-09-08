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
    Init();
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
            CleanColors();
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
            SetClassColor(data.sideTwo.hLayer3.cells, '.layer3-two td');
            SetClassColor(data.sideTwo.hLayer2.cells, '.layer2-two td');
            SetClassColor(data.sideTwo.hLayer1.cells, '.layer1-two td');
            //Side 3
            SetClassColor(data.sideThree.hLayer3.cells, '.layer3-three td');
            SetClassColor(data.sideThree.hLayer2.cells, '.layer2-three td');
            SetClassColor(data.sideThree.hLayer1.cells, '.layer1-three td');
            //Side 4
            SetClassColor(data.sideFour.hLayer3.cells, '.layer3-four td');
            SetClassColor(data.sideFour.hLayer2.cells, '.layer2-four td');
            SetClassColor(data.sideFour.hLayer1.cells, '.layer1-four td');
            //Side 5
            SetClassColor(data.sideFive.hLayer3.cells, '.layer3-five td');
            SetClassColor(data.sideFive.hLayer2.cells, '.layer2-five td');
            SetClassColor(data.sideFive.hLayer1.cells, '.layer1-five td');
            //Side 6
            SetClassColor(data.sideSix.hLayer3.cells, '.layer3-six td');
            SetClassColor(data.sideSix.hLayer2.cells, '.layer2-six td');
            SetClassColor(data.sideSix.hLayer1.cells, '.layer1-six td');
        });
    });
}

function Init() {
    $.ajax({
        url: "Home/Init",
        context: document.body
    }).done(function (data) {
        //Side 1
        SetClassColor(data.sideOne.hLayer3.cells, '.layer3-one td');
        SetClassColor(data.sideOne.hLayer2.cells, '.layer2-one td');
        SetClassColor(data.sideOne.hLayer1.cells, '.layer1-one td');
        //Side 2
        SetClassColor(data.sideTwo.hLayer3.cells, '.layer3-two td');
        SetClassColor(data.sideTwo.hLayer2.cells, '.layer2-two td');
        SetClassColor(data.sideTwo.hLayer1.cells, '.layer1-two td');
        //Side 3
        SetClassColor(data.sideThree.hLayer3.cells, '.layer3-three td');
        SetClassColor(data.sideThree.hLayer2.cells, '.layer2-three td');
        SetClassColor(data.sideThree.hLayer1.cells, '.layer1-three td');
        //Side 4
        SetClassColor(data.sideFour.hLayer3.cells, '.layer3-four td');
        SetClassColor(data.sideFour.hLayer2.cells, '.layer2-four td');
        SetClassColor(data.sideFour.hLayer1.cells, '.layer1-four td');
        //Side 5
        SetClassColor(data.sideFive.hLayer3.cells, '.layer3-five td');
        SetClassColor(data.sideFive.hLayer2.cells, '.layer2-five td');
        SetClassColor(data.sideFive.hLayer1.cells, '.layer1-five td');
        //Side 6
        SetClassColor(data.sideSix.hLayer3.cells, '.layer3-six td');
        SetClassColor(data.sideSix.hLayer2.cells, '.layer2-six td');
        SetClassColor(data.sideSix.hLayer1.cells, '.layer1-six td');
    })
}

function SetClassColor(cells, class1) {
    for (let i = 0; i < cells.length; i++) {
        switch (cells[i]) {
            case RED: $($(class1)[i]).addClass('red'); break;
            case YELLOW: $($(class1)[i]).addClass('yellow'); break;
            case ORANGE: $($(class1)[i]).addClass('orange'); break;
            case WHITE: $($(class1)[i]).addClass(''); break;
            case BLUE: $($(class1)[i]).addClass('blue'); break;
            case GREEN: $($(class1)[i]).addClass('green'); break;
        }
    }
}

function CleanColors() {
    $('.red').removeClass('red');
    $('.orange').removeClass('orange');
    $('.yellow').removeClass('yellow');
    $('.blue').removeClass('blue');
    $('.green').removeClass('green');
}