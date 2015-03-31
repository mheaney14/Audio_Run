using UnityEngine;
using System.Collections;

public class CollectScript : MonoBehaviour {
	[SerializeField] private double add;
void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			GameManager.score = GameManager.score + add;
			Destroy(gameObject);
					}
}
}
