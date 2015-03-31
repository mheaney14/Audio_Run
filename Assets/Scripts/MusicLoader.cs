using UnityEngine;
using System.Collections;
public class MusicLoader : MonoBehaviour {

	string myPath;
	bool canPlay = true;
	// Use this for initialization
	void Start () {
		//myPath = "/mnt/sdcard/music";

		UniFileBrowser.use.OpenFileWindow (OpenFile);
		WWW myClip = new WWW("file:///" + myPath);
		audio.clip = myClip.GetAudioClip (false, false);
		if (audio.clip.length > 7) {
			//some code here
			canPlay = false;
				}
		canPlay = true;


	}
	
	// Update is called once per frame
	void Update () {
				if (!audio.isPlaying && audio.clip.isReadyToPlay && canPlay) {
						audio.Play ();
				}
		}
	void OpenFile (string pathToFile) {
		myPath = pathToFile;
	}

}
