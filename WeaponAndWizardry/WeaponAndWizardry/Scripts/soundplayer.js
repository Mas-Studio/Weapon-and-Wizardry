//Author: Jia Qi Lee (George) Date: 2017-11-15

var effectPlaying;
var backgroundPlaying;
var loadCount = 0;
var bgm = [
    { src: "content/sounds/bgm/OpeningTheme1.mp3", id: "content/sounds/bgm/OpeningTheme1.mp3" },
    { src: "content/sounds/bgm/OpeningTheme2.mp3", id: "content/sounds/bgm/OpeningTheme2.mp3" },
    { src: "content/sounds/bgm/PeaceTheme.mp3", id: "content/sounds/bgm/PeaceTheme.mp3" },
    { src: "content/sounds/bgm/CampTheme.mp3", id: "content/sounds/bgm/CampTheme.mp3" },
    { src: "content/sounds/bgm/IliasTheme.mp3", id: "content/sounds/bgm/IliasTheme.mp3" },
    { src: "content/sounds/bgm/TravelTheme.mp3", id: "content/sounds/bgm/TravelTheme.mp3" },
    { src: "content/sounds/bgm/CrisisTheme.mp3", id: "content/sounds/bgm/CrisisTheme.mp3" },
    { src: "content/sounds/bgm/BattleTheme.mp3", id: "content/sounds/bgm/BattleTheme.mp3" },
    { src: "content/sounds/bgm/TownTheme.mp3", id: "content/sounds/bgm/TownTheme.mp3" },
    { src: "content/sounds/bgm/CastleTheme.mp3", id: "content/sounds/bgm/CastleTheme.mp3" },
    { src: "content/sounds/bgm/VillageTheme.mp3", id: "content/sounds/bgm/VillageTheme.mp3" },
    { src: "content/sounds/bgm/MysteryTheme.mp3", id: "content/sounds/bgm/MysteryTheme.mp3" },
    { src: "content/sounds/bgm/BossBuildUpTheme.mp3", id: "content/sounds/bgm/BossBuildUpTheme.mp3" },
    { src: "content/sounds/bgm/BossTheme.mp3", id: "content/sounds/bgm/BossTheme.mp3" },
    { src: "content/sounds/bgm/VictoryTheme.mp3", id: "content/sounds/bgm/VictoryTheme.mp3" },
];

var sfx = [
    { src: "content/sounds/sfx/explode.wav", id: "content/sounds/sfx/explode.wav" },
    { src: "content/sounds/sfx/helpme.mp3", id: "content/sounds/sfx/helpme.mp3" },
];

var totalElements = bgm.length + sfx.length;
console.log(totalElements + " Sound files detected.");
//Loads all the sounds into SoundJs
function loadSound() {
    createjs.Sound.addEventListener("fileload", handleLoad);
    createjs.Sound.registerSounds(bgm);
    createjs.Sound.registerSounds(sfx);
}

//Fired for every file loaded
function handleLoad(event) {
    // Do something with the loaded sound
    if (event.src == "content/sounds/bgm/OpeningTheme1.mp3") {
        playbgm("content/sounds/bgm/OpeningTheme1.mp3");
    }
    loadCount++;
    if (loadCount < 5) {
        var percent = Number(localStorage.getItem("percentLoaded"));
        percent += 10;
        localStorage.setItem("percentLoaded", percent);
    }
    console.log("Loading: " + event.src);
    if (loadCount >= 5) {
        console.log("load complete!");
        localStorage.setItem("soundLoaded", "true");
    }
}

//Plays a background sound
function playbgm(soundID) {
    if (backgroundPlaying != null && backgroundPlaying.playState == "playSucceeded")
        backgroundPlaying.stop();
    var props = new createjs.PlayPropsConfig().set({ loop: -1 });
    console.log(props);
    console.log("Playing BGM: " + soundID);
    backgroundPlaying = createjs.Sound.play(soundID, props);
    adjustBgmVolume(bgmSlider.value);
}

//Plays a sound effect
function playSound(soundID, loop) {
    if (effectPlaying != null && effectPlaying.playState == "playSucceeded")
        effectPlaying.stop();
    var props = new createjs.PlayPropsConfig().set({ loop: Number(loop) });
    console.log(props);
    console.log("Playing SFX: " + soundID);
    effectPlaying = createjs.Sound.play(soundID, props);
    adjustSfxVolume(sfxSlider.value);
}

//Adjusts the sound effect volume
function adjustSfxVolume(vol) {
    if (effectPlaying != null && effectPlaying.playState == "playSucceeded") {
        effectPlaying.volume = vol / 100;
    }
}

//Adjusts the Background music volume
function adjustBgmVolume(vol) {
    if (backgroundPlaying != null && backgroundPlaying.playState == "playSucceeded") {
        backgroundPlaying.volume = vol / 100;
    }
    //console.log(backgroundPlaying);
}

loadSound();

//SignalR setup code
$(function () {
    // Declare a proxy to reference the hub.
    var player = $.connection.soundPlayerHub;

    player.client.playSfx = function (sound, loop) {
        playSound(sound, loop);
    };

    player.client.stopSfx = function () {
        if (effectPlaying != null && effectPlaying.playState == "playSucceeded")
            effectPlaying.stop();
    };

    player.client.playBackground = function (sound) {
        playbgm(sound);
    };

    player.client.stopBackground = function (sound) {
        if (backgroundPlaying != null && backgroundPlaying.playState == "playSucceeded")
            backgroundPlaying.stop();
    };

    player.client.stopAllSounds = function () {
        createjs.Sound.stop();
        backgroundPlaying = null;
        effectPlaying = null;
    };

    // Start the connection
    $.connection.hub.logging = true;
    $.connection.hub.start().done(function () {
        // Call the Send method on the hub.
        setTimeout(function () {
            var sessionid = localStorage.getItem("sessionid");
            console.log("Establishing connection with session id: " + sessionid);
            player.server.registerClient(sessionid);
        }, 1000);
    });
});

///Code for volume slider
var sfxSlider = document.getElementById("sfxRange");
var bgmSlider = document.getElementById("bgmRange");

// Update the current slider value (each time you drag the slider handle)
sfxSlider.oninput = function (effectPlaying) {
    adjustSfxVolume(this.value);
}

bgmSlider.oninput = function (backgroundPlaying) {
    adjustBgmVolume(this.value);
}