using UnityEngine;
using System.Collections;

public class SpawnerFollow : MonoBehaviour {
	
	public Transform player;
	// Update is called once per frame
	[SerializeField] private int offset = 10; // the offset of the spawner from the player
	[SerializeField] private float height=  10f; //Height in realtion to the player

	void Start(){
		height = player.position.y + height;
		
	}


	void Update () {
		transform.position = new Vector3 (player.position.x + offset,height, 10);
	}
}
