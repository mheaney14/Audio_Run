using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel(7);
			return;		
		}

		if (other.tag == "MainCamera") {
			return;
		}

		if (other.tag == "DND") {
			return;
		}
		if (other.gameObject.transform.parent) {
						Destroy (other.gameObject.transform.parent.gameObject);
		} 
		

		else {
			Destroy (other.gameObject);
		}
	
	}
}
