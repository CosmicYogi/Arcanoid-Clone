 using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;
	public Sprite[] sprite;
	private int timeHits;
	private LevelManager lm;
	public static int breakableCount = 0;
	private bool isBreakable ;
	// Use this for initialization
	void Start () {
		if (gameObject.tag == "Breakable"){
			isBreakable = true;
		}
		if (gameObject.tag == "UnBreakable"){
			isBreakable = false;
		}
		// Samaj aa gaya ye kyon ho raha hai.
		// This is because
		// breakableCount is a static variable of Brick class.
		// and because it is there on every brick so the Start() method will be called the number of Bricks are there.
		// Ones for every brick.
		print ("is Breakable is "+isBreakable);
		if (isBreakable) { 
			breakableCount++;
			//print (breakableCount);
		}
		lm = GameObject.FindObjectOfType<LevelManager> ();
		timeHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D target){
		AudioSource.PlayClipAtPoint (crack,new Vector3(0,0,0));
		// the constructor takes two argumests 1st is audio file 2nd is the position at which the sound plays.
		// It gives like 3D sound effect because if you give the position via this.transform.position
		// Then every time brick will break it will be at different distace from Audio listener which is attached to Main camera.
		if (isBreakable){
			HandleHits ();
		}
	}

	void HandleHits(){
		timeHits += 1;
		int maxHits = sprite.Length + 1; 
		if (timeHits >= maxHits) { // is >= Because suppose the case of a super ball which does the damage of 2 at a time so in that case times hit would bypass the mas Hits.
			breakableCount--;
			print (breakableCount);
			lm.BrickDestroyed (); // Ye messages waala natak bhi samaj nahi aaya hai. Doubt puchna hai.
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
