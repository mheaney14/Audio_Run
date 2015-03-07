using UnityEngine;
using System.Collections;

public class CameraFollowRun : MonoBehaviour {

	public float CameraOffsetX = 15;
	public float CameraOffsetY = 6;

	public Transform player;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + CameraOffsetX, player.position.y + CameraOffsetY, -10);
		//transform.position = new Vector3 (0, player.position.y + CameraOffsetY, -10);
	}
}
