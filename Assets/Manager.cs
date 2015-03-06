using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	void changeScene(string sceneName) {
		Application.LoadLevel (sceneName);
		}
}
