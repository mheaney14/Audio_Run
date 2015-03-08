using UnityEngine;
using System.Collections;

public class NotBadBlockScript : MonoBehaviour {
	public static Transform block;
	//public float xPos = block.position.x;
	public Vector2 topLeft = new Vector2 (block.position.x - block.transform.localScale.x/2, block.position.y + block.transform.localScale.y/2);
	public Vector2 bottomRight = new Vector2 (block.position.x + block.transform.localScale.x/2, block.position.y + block.transform.localScale.y/2);
	Collider2D other;
	void Update()
	{
		if (Physics2D.OverlapArea (topLeft, bottomRight) == true) {
						Destroy (block.gameObject);
				}

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Block") {
			Destroy (other.gameObject);
			}
	}
}
