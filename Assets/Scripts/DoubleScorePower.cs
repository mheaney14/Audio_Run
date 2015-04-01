using UnityEngine;
using System.Collections;
using System.Threading;

 class DoubleScorePower1 : MonoBehaviour {
	[SerializeField] private float doubleTime;
	// Use this for initialization	
	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player") {
			GameManager.doubleScore = true;
			Destroy(gameObject);
				}
			//GameManager.doubleScore = true;
//			GetComponent(MeshRenderer).enabled = false;
			//Thread.Sleep(doubleTime);
			//GameManager.doubleScore = false;
//			Destroy(GameObject);
		//}
	}
}
