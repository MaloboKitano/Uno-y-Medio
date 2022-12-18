using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public GameObject setupCan;
	public GameObject[] toggles = new GameObject[5];

	void Start () { //start function
	}
	public void exit() { //exits the app
		Application.Quit ();
	}
	public void setup(bool openClose) { //starts the setup canvas screen
		setupCan.SetActive (openClose);			
	}
	public void play() { //finds the toggle that is on to decide how many ai players there will be
		for (int i = 0; i < 5; i++) {
			if (toggles [i].GetComponent<Toggle> ().isOn) {
				Control.numbOfAI = i + 1;
				break;
			}				
		}
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Main"); //then it loads the play screen
	}
	void Update() {
	}
}
