using UnityEngine;
using System.Collections;

public class NotBadBlockScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Block") {
			Destroy (other.gameObject);
			}
	}
}
