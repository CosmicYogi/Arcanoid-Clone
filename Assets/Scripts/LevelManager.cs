using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void  loadLevel(string name){
		UnityEngine.SceneManagement.SceneManager.LoadScene (name);
	}
	public void quitGame(){
		Application.Quit();
	}

	public void LoadNextLevel(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);

	}
}
