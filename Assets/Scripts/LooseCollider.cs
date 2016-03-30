using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
	private LevelManager lm;

	void Start(){
		lm = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D(Collider2D coll){
		print ("trigger");
		lm.loadLevel ("Scenes/Loose");
	}
	void OnCollisionEnter2D(Collision2D coll){
		print ("collision");
	}
}