using UnityEngine;
using System.Collections;
public class ManagerScript : MonoBehaviour {
	public static bool enabled = true;
	//Enabled sets if changeScene works
	public void changeScene(string sceneName) {
		if (enabled) {
						Application.LoadLevel (sceneName);
				}
		}




	public void update() {
		}

	private void FixedUpdate() {

	}


}
