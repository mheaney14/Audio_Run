using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {
	public static string path;
	public static string difficulty;
	static private double scoreLocal;
	// Use this for initialization
	void Start () {
	
	} 

	static public void setscoreLocal(double scoreFrom)
	{
		scoreLocal = scoreFrom;
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
