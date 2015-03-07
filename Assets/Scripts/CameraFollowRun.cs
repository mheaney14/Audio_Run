using UnityEngine;
using System.Collections;

public class CameraFollowRun : MonoBehaviour {

	public float CameraOffsetX = 15;
	public float CameraOffsetY = 6;
	public static float oldPositionX = 0;
	public static float oldPositionY = 0;
	public Transform player;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		oldPositionX = player.position.x + CameraOffsetX;
		oldPositionY = player.position.y + CameraOffsetY;
		transform.position = new Vector3 (player.position.x + CameraOffsetX, player.position.y + CameraOffsetY, -10);
		//transform.position = new Vector3 (0, player.position.y + CameraOffsetY, -10);
	}
}
