using UnityEngine;
using System.Collections;
using System.Threading;
public class SpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1;
	public float spawnMax = 2;
	public float delta = 3;
	public float max = 20;


	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn(){
		if (camera.oldPositionX != camera.position.x && camera.oldPositionY != camera.position.y) {
						Invoke ("Spawn", Random.Range (spawnMin, spawnMax)); 
						float deltapos = Random.Range (-delta, delta);
						Vector3 position = new Vector3 (transform.position.x, deltapos);
						Instantiate (obj [Random.Range (0, obj.Length)], position, Quaternion.identity);
						transform.Translate (Vector3.up * deltapos);
						Thread.Sleep (1);
				}
	}
}
