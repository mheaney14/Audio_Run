using UnityEngine;
using System.Collections;

public class BadBlockScript : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			GameManager.score = GameManager.score - 1000;
			Destroy (gameObject);
			//Application.LoadLevel(0);
		}
		
	/*	if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject);
		} 
		else {
			Destroy (other.gameObject);
		}
	*/	
	}
}
