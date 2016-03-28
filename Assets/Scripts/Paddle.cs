using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	float paddle = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			paddle = (Input.mousePosition.x / Screen.width * 16);
		
		//print (paddle);
		this.transform.position = new Vector3 (Mathf.Clamp(paddle,0.5f,15.5f), this.transform.position.y, 0);
	}
}
