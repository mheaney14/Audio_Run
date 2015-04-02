using UnityEngine;
using System.Collections;
using System.Threading;

public class GameManager : MonoBehaviour {
	[SerializeField]  public static double score;
	public static bool doubleScore;
	[SerializeField]  private int scoreMulti;
    public static double increment;
	[SerializeField]  private string difficulty;
	private string scoreString;


	// Use this for initialization
	void Start () {
		increment = 1;
		score = 0;
		if (difficulty == "Easy") {
						scoreMulti = scoreMulti / 2;
				}
	}
	
	// Update is called once per frame
	void Update () {
		if (doubleScore == true) {
			score = (score + increment * 10) * scoreMulti;
			scoreString = "Score: " + score.ToString ();
				} 
		else {
						score = (score + increment) * scoreMulti;
						scoreString = "Score: " + score.ToString ();
						//Thread.Sleep(100);
				}
		}
	void OnGUI (){
			//var col = GUI.color;
			//col.a = alpha;
			//GUI.color = col;
			GUI.Label (new Rect(100, 275, 500, 1000), scoreString);
			//col.a = 1.0f;
			//GUI.color = col;
		}
	}

