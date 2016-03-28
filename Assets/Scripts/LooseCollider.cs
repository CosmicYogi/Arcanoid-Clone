using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
	public LevelManager lm;
	void OnTriggerEnter2D(Collider2D coll){
		print ("trigger");
		lm.loadLevel ("Scenes/Win");
	}
	void OnCollisionEnter2D(Collision2D coll){
		print ("collision");
	}
}