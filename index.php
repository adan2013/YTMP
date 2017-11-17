<?php
if(isset($_GET['vid'])){
    $vid = $_GET['vid'];
    if(isset($_GET['stime'])){
        $stime = $_GET['stime'];
    }else{
        $stime = 0;
    }
}else{
    echo 'nie podano ID filmiku!';
    exit;
}
?>
<!DOCTYPE html>
<html>
    <body>
        <div id="player"></div>
        <br />
        CURRENT: <div id="INFOcurrent">0</div>
        DURATION: <div id="INFOduration">0</div>
        STATE: <div id="INFOstate">3</div>
        IS_MUTED: <div id="INFOismuted">false</div>
        VOLUME: <div id="INFOvolume">100</div>
        <br />
        <button type="button" id="play" onclick="player.playVideo()">PLAY</button>
        <button type="button" id="pause" onclick="player.pauseVideo()">PAUSE</button>
        <button type="button" id="mute" onclick="player.mute()">MUTE</button>
        <button type="button" id="unmute" onclick="player.unMute()">UNMUTE</button>
        <button type="button" id="setvol" onclick="player.setVolume(0)">SET VOLUME</button>
        <button type="button" id="rewind" onclick="player.seekTo(0, true)">REWIND</button>
        <script>
            var INFOcurrent = document.getElementById('INFOcurrent');
            var INFOduration = document.getElementById('INFOduration');
            var INFOstate = document.getElementById('INFOstate');
            var INFOismuted = document.getElementById('INFOismuted');
            var INFOvolume = document.getElementById('INFOvolume');
            var tag = document.createElement('script');
            tag.src = "https://www.youtube.com/iframe_api";
            var firstScriptTag = document.getElementsByTagName('script')[0];
            firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);
            var player;
            function onYouTubeIframeAPIReady() {
                    player = new YT.Player('player', {
                    height: '240',
                    width: '360',
                    videoId: '<?php echo $vid; ?>',
                    playerVars: { 'disablekb' : 1, 'start' : <?php echo $stime; ?> },
                    events: {
                    'onReady': onPlayerReady,
                    'onStateChange': onPlayerStateChange
                    }
                });
            }

            function onPlayerReady(event) {
                event.target.playVideo();
            }

            function onPlayerStateChange(event) {
                INFOstate.innerHTML = event.data;
                if (event.data == YT.PlayerState.PLAYING) {
                    setInterval(function(){ TimeVideo(); }, 500);
                }
            }

            function TimeVideo() {
                INFOcurrent.innerHTML = Math.round(player.getCurrentTime());
                INFOduration.innerHTML = Math.round(player.getDuration());
                INFOismuted.innerHTML = player.isMuted();
                INFOvolume.innerHTML = Math.round(player.getVolume());
            }
        </script>
    </body>
</html>