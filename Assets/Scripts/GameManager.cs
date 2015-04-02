using UnityEngine;
using System.Collections;
using System.Threading;

public class GameManager : MonoBehaviour {
	[SerializeField]  public static double score;
	public static bool doubleScore;
	[SerializeField]  private int scoreMulti;
    public static double increment;
	 private string difficulty;
	private string scoreString;


	// Use this for initialization
	void Start () {
		difficulty = DoNotDestroy.difficulty;
		increment = 1;
		score = 0;
		if (difficulty == "Easy") {
						scoreMulti = scoreMulti / 2;
			Debug.Log("Easy");
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
		//GUI.color = col; //100, 275, 500, 1000

		//><size=40>Lose</size>
		GUI.Label (new Rect(100, 275, 500, 1000),"<size=40>" + scoreString + "</size>");
			//col.a = 1.0f;
			//GUI.color = col;
		}
	}

