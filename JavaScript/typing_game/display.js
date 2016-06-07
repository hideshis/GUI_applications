class Target {
    constructor () {
        this.target = "hogehoge.com";
        this.location = 0;
    }

    updateTargetAndLocation () {
        if (this.location == (this.target.length - 1)) {
            this.target = "nameneco.com"
            this.location = 0;
        } else {
            this.target = this.target.replaceAt(this.location, "_");
            this.location += 1;        
        }
    }

    get checkingTargetChar () {
        return this.target.charAt(this.location);
    }
}

class Score {
    constructor () {
        this.score = 0;
    }

    updateScore () {
        this.score += 1;
    }
}

String.prototype.replaceAt=function(index, character) {
    return this.substr(0, index) + character + this.substr(index+character.length);
}

function Display (target, scoreLabel, missLabel) {
    'use strict';

    var target = document.getElementById('target').textContent = target;
    var scoreLabel = document.getElementById('score').textContent = scoreLabel;
    var missLabel = document.getElementById('miss').textContent = missLabel;
};

document.onkeypress = function (e) {
    if (e.key == target.checkingTargetChar) {
        target.updateTargetAndLocation();
        scoreLabel.updateScore();
        Display(target.target, scoreLabel.score, missLabel.score);
    } else {
        missLabel.updateScore();
        Display(target.target, scoreLabel.score, missLabel.score);
    }
};

var target = new Target();
var scoreLabel = new Score();
var missLabel = new Score();

Display(target.target, scoreLabel.score, missLabel.score);