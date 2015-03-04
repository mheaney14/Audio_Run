#pragma strict

    var MusicFolder : System.IO.DirectoryInfo;
    var myClip : WWW;
    var myPath : String;
    function Start()
    {
	    myPath = "/mnt/sdcard/music";
	    MusicFolder = new System.IO.DirectoryInfo(myPath);
	    myClip = new WWW("file:///" + MusicFolder.GetFiles()[0].FullName);
	    audio.clip = myClip.GetAudioClip(false, false);
    }
    function Update()
    {
	    if (!audio.isPlaying && audio.clip.isReadyToPlay){
	    audio.Play();
    }
    }