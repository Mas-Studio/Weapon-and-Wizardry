//Author: Jia Qi Lee (George) Date: 2017-12-08
openSoundPlayer();

var sessionid = getCookie("sessionid");
localStorage.setItem("soundLoaded", "false");
localStorage.setItem("sessionid", sessionid);
var soundLoaded = localStorage.getItem("soundLoaded");
var elapsed = 0;
var percentText = document.getElementById('percentText');
localStorage.setItem("percentLoaded", Number(percentText.innerHTML));
document.getElementById('contents').style.visibility = "hidden";

var interval = setInterval(checkIfLoadCompleted, 1000);

function checkIfLoadCompleted() {
    elapsed++;
    if (soundLoaded === "true" || elapsed > 10) {
        clearInterval(interval);
        document.getElementById('interactive');
        document.getElementById('load').style.visibility = "hidden";
        document.getElementById('contents').style.visibility = "visible";
        console.log("Load complete!");
    }
    else {
        soundLoaded = localStorage.getItem("soundLoaded");
        percentText.innerHTML = Number(localStorage.getItem("percentLoaded")) + (elapsed * 5);
        console.log("Loading sounds...");
    }
}

function openSoundPlayer() {
    var player = window.open("SoundPlayer.html", "name", "height=400,width=500");
    try {
        player.blur();
    }
    catch (e) {
        alert("Popup Blocker Detected: Please allow popups if you want sounds enabled!");
    }
}

function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}