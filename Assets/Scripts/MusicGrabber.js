#pragma strict

    var MusicFolder : System.IO.DirectoryInfo;
    var myClip : WWW;
    var myPath : String;
    
    function Start()
    {
    
    	UniFileBrowser.use.OpenFileWindow (OpenFile)
    	
	    //myPath = "/mnt/sdcard/music";
	    //MusicFolder = new System.IO.DirectoryInfo(myPath);
	    myClip = new WWW("file:///" + myPath);
	    audio.clip = myClip.GetAudioClip(false, false);
    }
    function Update()
    {
	    if (!audio.isPlaying && audio.clip.isReadyToPlay){
	    audio.Play();
    }
    
    
    
    
    }
    
    void OpenFile (string pathToFile) {
		myPath = pathToFile;
	}