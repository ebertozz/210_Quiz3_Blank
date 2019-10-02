using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallFollow : MonoBehaviour {



	public GameObject player;   // public var that refers to the game object we want to follow player/ball
	public Text tellPlayerLost;
	public Button startButton; 

	private Vector3 offset;   // private var that determines the camera distance from the player/ball



	// Use this for initialization
	void Start () {
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + 0.2f * offset;

		if (player.transform.position.x < -10) {
			
			tellPlayerLost.text = "You lost!";
			startButton.gameObject.SetActive (true);

		} else if (player.transform.position.x > 10){

			tellPlayerLost.text = "You won!";
			startButton.gameObject.SetActive (true);
			}
		}

	public void restartLevel(){
	
		SceneManager.LoadScene ("_Scene_1");
	}

}
