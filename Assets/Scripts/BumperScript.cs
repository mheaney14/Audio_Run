using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel(0);
			return;		
		}

		if (other.tag == "MainCamera") {
		}

		if (other.gameObject.transform.parent) {
						Destroy (other.gameObject.transform.parent.gameObject);
		} 
		

		else {
			Destroy (other.gameObject);
		}
	
	}
}
