#pragma strict

    var MusicFolder : System.IO.DirectoryInfo;
    var myClip : WWW;
    var myPath : String;
    var opened : int;
    
    function Start()
    {
    	//Time.timeScale =0;
    	opened = 0;	
    	UniFileBrowser.use.OpenFileWindow (OpenFolder);
    	
	    //myPath = "/mnt/sdcard/music";
	   
	    //Time.timeScale =1;
    }
        function Update()
    {
    	if (opened == 1){
    			    if (!audio.isPlaying && audio.clip.isReadyToPlay){
	   					 audio.Play();
    				}
    	}

    }
    
    function loadMusic(){
    	
    	MusicFolder = new System.IO.DirectoryInfo(myPath);
	    myClip = new WWW("file:///" + MusicFolder.GetFiles()[0].FullName);
	    audio.clip = myClip.GetAudioClip(false, false);
	    opened = 1;
	    
    }
    
	function OpenFolder (pathToFile : String) {
		Debug.Log(pathToFile);
		myPath = pathToFile;
		loadMusic();
	}
    
    
    
    
    
    
