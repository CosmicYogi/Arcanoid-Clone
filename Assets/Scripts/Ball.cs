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
			gameObject.transform.position = paddle.transform.position + paddleToBallVector; //remember this one.
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, ball launched");
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (3, 10);
				hasStarted = true;
			}
		}
	}
	void OnCollisionEnter2D(Collision2D target){
		Vector2 randomness = new Vector2 (Random.Range (0f, 0.2f), Random.Range (0f, 0.2f));
		print (randomness);


		if (gameObject.GetComponent<Rigidbody2D> ().velocity.x > 0 && gameObject.GetComponent<Rigidbody2D> ().velocity.y > 0) 
			gameObject.GetComponent<Rigidbody2D> ().velocity += new Vector2 (randomness.x, randomness.y);
	    else if (gameObject.GetComponent<Rigidbody2D> ().velocity.x > 0 && gameObject.GetComponent<Rigidbody2D> ().velocity.y < 0)
			gameObject.GetComponent<Rigidbody2D> ().velocity += new Vector2 (randomness.x, -randomness.y);
		else if (gameObject.GetComponent<Rigidbody2D> ().velocity.x < 0 && gameObject.GetComponent<Rigidbody2D> ().velocity.y > 0)
			gameObject.GetComponent<Rigidbody2D> ().velocity += new Vector2 (-randomness.x, randomness.y);
		else if (gameObject.GetComponent<Rigidbody2D> ().velocity.x < 0 && gameObject.GetComponent<Rigidbody2D> ().velocity.y < 0)
			gameObject.GetComponent<Rigidbody2D> ().velocity += new Vector2 (-randomness.x, -randomness.y);
		
		if (!hasStarted) {
			GetComponent<AudioSource>().Play (); //This would be like this in Unity 5
		}
	}
}

