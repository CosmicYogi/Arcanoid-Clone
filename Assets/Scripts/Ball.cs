using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	Vector3 paddleToBallVector;
	bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		// print ("didtence b/w ball & paddle is "+paddleToBallVector.y);
	}

	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			gameObject.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, ball launched");
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (3, 10);
				hasStarted = true;
			}
		}
	}
}
