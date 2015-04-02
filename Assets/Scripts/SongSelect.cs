using UnityEngine;
using System.Collections;

public class SongSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void grabMusic(){

		if (Application.platform == RuntimePlatform.Android){
			UniFileBrowser.use.SetPath ("/mnt/sdcard/music");
		}
		UniFileBrowser.use.OpenFileWindow (OpenFile);
		
	}
	// Update is called once per frame
	void OpenFile (string pathToFile){
		//myPath = pathToFile
		DoNotDestroy.setPath(pathToFile);
	
	}



	void Update () {
	
	}
}
