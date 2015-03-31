using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	public void pause() {
		if (Time.timeScale == 1) {
				Time.timeScale = 0;
			GameManager.increment = 0;
				} else {
			Time.timeScale =1;
			GameManager.increment = 1;

				}
	}

}
