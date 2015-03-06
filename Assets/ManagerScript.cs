using UnityEngine;
using System.Collections;

public class ManagerScript : MonoBehaviour {

	public void changeScene(string sceneName) {
		Application.LoadLevel (sceneName);
		}
}
