using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	Vector3 paddleToBallVector;
	bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		// print ("didtence b/w ball & paddle is "+paddleToBallVector.y);
	}

	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			gameObject.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, ball launched");
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 10);
				hasStarted = true;
			}
		}
	}
}
