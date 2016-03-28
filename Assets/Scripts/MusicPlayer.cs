using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	// Use this for initialization
	void Awake(){
		Debug.Log ("Awake method " + GetInstanceID());
	}
	void Start () {
		Debug.Log ("Start Method " + GetInstanceID());
		if (instance != null) {
			Destroy (gameObject);
			Debug.Log ("game object destroyed");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
