#pragma strict

    var MusicFolder : System.IO.DirectoryInfo;
    var myClip : WWW;
    var myPathLocal : String;
    var opened : int;

function Start () {
		myPathLocal = MusicGrabber.myPath;	
		loadMusic();
}
 function loadMusic(){
    	
    	MusicFolder = new System.IO.DirectoryInfo(myPathLocal);
	    myClip = new WWW("file:///" + MusicFolder.GetFiles()[0].FullName);
	    audio.clip = myClip.GetAudioClip(false, false);
	    opened = 1;
	    
	    
    }


function Update () {
		    	if (opened == 1){
    			    if (!audio.isPlaying && audio.clip.isReadyToPlay){
	   					 audio.Play();
	   					 //playing = 1;
	   					//Time.timeScale = 1;
    				}
    	}
}