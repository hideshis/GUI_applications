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

class Speed {
    constructor() {
        this.time = 0;
        this.numTyped = 0;
    }

    getSpeed() {
        return (this.numTyped / this.time).toFixed(2);
    }
}

String.prototype.replaceAt=function(index, character) {
    return this.substr(0, index) + character + this.substr(index+character.length);
}

function Display (target, scoreLabel, missLabel, typingSpeed) {
    'use strict';

    /*
    var target = document.getElementById('target').textContent = target;
    var scoreLabel = document.getElementById('score').textContent = scoreLabel;
    var missLabel = document.getElementById('miss').textContent = missLabel;
    var typingSpeed = document.getElementById('speed').textContent = typingSpeed;
    */
    document.getElementById('target').textContent = target;
    document.getElementById('score').textContent = scoreLabel;
    document.getElementById('miss').textContent = missLabel;
    document.getElementById('speed').textContent = typingSpeed;

};

document.onkeypress = function (e) {
    if (e.key == target.checkingTargetChar) {
        typingSpeed.numTyped += 1;
        target.updateTargetAndLocation();
        scoreLabel.updateScore();
        Display(target.target, scoreLabel.score, missLabel.score, typingSpeed.getSpeed());
    } else {
        missLabel.updateScore();
        Display(target.target, scoreLabel.score, missLabel.score, typingSpeed.getSpeed());
    }
};

setInterval(function () {
    typingSpeed.time += 0.001;
    Display(target.target, scoreLabel.score, missLabel.score, typingSpeed.getSpeed());
},1);

var target = new Target();
var scoreLabel = new Score();
var missLabel = new Score();
var typingSpeed = new Speed();

Display(target.target, scoreLabel.score, missLabel.score, typingSpeed.getSpeed());