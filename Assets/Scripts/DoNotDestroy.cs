using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {
	public static string path;
	public static string difficulty;
	// Use this for initialization
	void Start () {
	
	} 

	public void setDifficulty(string diff) {
		difficulty = diff;
	} 
	
	static public void setPath(string pathFrom) {
		path = pathFrom;
	} 

	// Update is called once per frame
	void Update () {
	
	}
	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}
}
