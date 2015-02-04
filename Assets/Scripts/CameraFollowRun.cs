using UnityEngine;
using System.Collections;

public class CameraFollowRun : MonoBehaviour {

	public float CameraOffset = 4;

	public Transform player;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + CameraOffset, 0, -10);
	}
}
