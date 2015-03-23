using UnityEngine;
using System.Collections;
using System.Threading;

public class DoubleScorePower : MonoBehaviour {
	[SerializeField] private int doubleTime;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			GameManager.doubleScore = true;
//			GetComponent(MeshRenderer).enabled = false;
			//Thread.Sleep(doubleTime);
			//GameManager.doubleScore = false;
//			Destroy(GameObject);
		}
	}
}
