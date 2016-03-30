 using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] sprite;
	private int timeHits;
	private LevelManager lm;
	// Use this for initialization
	void Start () {
		lm = GameObject.FindObjectOfType<LevelManager> ();
		timeHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D target){
		timeHits += 1;
		int maxHits = sprite.Length + 1;
		if (timeHits >= maxHits) { // is >= Because suppose the case of a super ball which does the damage of 2 at a time so in that case times hit would bypass the mas Hits.
			Destroy (gameObject);
		} else {
			LoadSprites ();
		}
	}

	void LoadSprites(){
		int spriteIndex = timeHits - 1;
		this.GetComponent<SpriteRenderer> ().sprite = sprite [spriteIndex];
	}
	// TODO Remove this method once we actually win.
	void simulateWin(){
		lm.LoadNextLevel ();
	}
}
