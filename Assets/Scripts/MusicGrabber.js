#pragma strict

    var MusicFolder : System.IO.DirectoryInfo;
    var myClip : WWW;
    var myPath : String;
    var opened : int;
    public var playing : int = 0;
    private var message = "";
	private var alpha = 1.0;
    
    
    function grabMusic(){
     	opened = 0;	
    	UniFileBrowser.use.OpenFileWindow (OpenFile);
    
    }
    function isPlaying(){
    	if (playing == 1){
    		return true;
    	}
    }
    function Start()
    {

    	//Time.timeScale =0;



    	
	    //myPath = "/mnt/sdcard/music";
	   
	    //Time.timeScale =1;
    }
        function Update()
    {
    	if (opened == 1){
    			    if (!audio.isPlaying && audio.clip.isReadyToPlay){
	   					 audio.Play();
	   					 playing = 1;
	   					 Application.LoadLevel ("Runner");
    				}
    	}

    }
    
   // function OnGUI () {
	//GUI.color.a = alpha;
	//GUI.Label (Rect(100, 275, 500, 1000), message);
	//GUI.color.a = 1.0;
   //}
    
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
		loadMusic();
	}
    
    
    
    
    
    
