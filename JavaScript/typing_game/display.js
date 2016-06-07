class Target {
    constructor () {
        this.target = "hogehoge.com"
    }
}

class Score {
    constructor () {
        this.score = 0
    }
}

function initilaDisplay(target, scoreLabel, missLabel) {
    'use strict';

    var currentWord = 'apple';
    var currentLocation = 0;
    var score = 0;
    var miss = 0;
    var target = document.getElementById('target').innerText = target;
    var scoreLabel = document.getElementById('score').innerText = scoreLabel;
    var missLabel = document.getElementById('miss').innerText = missLabel;
};

var target = new Target();
var scoreLabel = new Score();
var missLabel = new Score();

initilaDisplay(target.target, scoreLabel.score, missLabel.score);

document.onkeypress = function (e) {
    var element = document.createElement('p');
    element.innerText = e.key;
    var objBody = document.getElementsByTagName("body").item(0);
    objBody.appendChild(element);
};