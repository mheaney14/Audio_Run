#pragma strict

    var MusicFolder : System.IO.DirectoryInfo;
    var myClip : WWW;
  	static var myPath : String;
    var opened : int;
    public var playing : int = 0;
    private var message = "";
	private var alpha = 1.0;
	private var Manager : GameObject;
    
    //This opens the file browser and run OpenFile() when the 
    function grabMusic(){
     	opened = 0;	

     	if (Application.platform == RuntimePlatform.Android){
     			UniFileBrowser.use.SetPath ("/mnt/sdcard/music");
     	}
    	UniFileBrowser.use.OpenFileWindow (OpenFile);
    	
    }

    
    function Start()
    {

	    
    
    }
        function Update()
    {
    	//if (opened == 1){
    		//	    if (!audio.isPlaying && audio.clip.isReadyToPlay){
	   		//			 audio.Play();
	   		//			 playing = 1;
	   		//			 Time.timeScale = 1;
    			//	}
    	//}

    }

    //Takes the music path and loads the song into the audiosourse
    function loadMusic(){
    	
    	MusicFolder = new System.IO.DirectoryInfo(myPath);
	    myClip = new WWW("file:///" + MusicFolder.GetFiles()[0].FullName);
	    audio.clip = myClip.GetAudioClip(false, false);
	    opened = 1;
	    
	    
    }
    
	function OpenFile (pathToFile : String) {
		//Debug.Log(pathToFile);
		myPath = pathToFile;
		//message = "You selected file: " + pathToFile;
		//loadMusic();
	}
    
    
    
    
    
    
