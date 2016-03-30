using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	private Ball ball;
	public bool autoPlay = false;
	float paddle = 0f;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay)
			MoveWithMouse ();
		else {
			AutoPlay ();
		}
	}

	void MoveWithMouse(){
		paddle = (Input.mousePosition.x / Screen.width * 16);

		this.transform.position = new Vector3 (Mathf.Clamp (paddle, 0.5f, 15.5f), this.transform.position.y, 0);
	}

	void AutoPlay(){
		//Vector3 ballPosition = ball.transform.position;

		this.transform.position = new Vector3 (ball.transform.position.x, this.transform.position.y,0);
	
	}
}
