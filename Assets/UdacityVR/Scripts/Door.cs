using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool locked = true;
	public bool opening = false;

	public AudioSource[] sounds = new AudioSource[2];


	void start()
	{
		
	}

    void Update() {
		if(opening)
			if(transform.position.y < 3.55f)
				transform.Translate (0, 2.5f * Time.deltaTime, 0);
    }

    public void OnDoorClicked() {

		if (!locked) {
			opening = true;
			sounds[0].Play ();
		} else {
			sounds[1].Play ();
		}
			
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
		locked = false;
    }


}