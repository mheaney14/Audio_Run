using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	public void pause() {
		if (Time.timeScale == 1) {
				Time.timeScale = 0;
				} else {
			Time.timeScale =1;
				}
	}

}
