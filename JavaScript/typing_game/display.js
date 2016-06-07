function initilaDisplay() {
    'use strict';

    var currentWord = 'apple';
    var currentLocation = 0;
    var score = 0;
    var miss = 0;
    var target = document.getElementById('target').innerText = "hogehoge.com";
    var scoreLabel = document.getElementById('score').innerText = 0;
    var missLabel = document.getElementById('miss').innerText = 0;
};

initilaDisplay();

document.onkeypress = function (e) {
    var element = document.createElement('p');
    element.innerText = e.key;
    var objBody = document.getElementsByTagName("body").item(0);
    objBody.appendChild(element);
};