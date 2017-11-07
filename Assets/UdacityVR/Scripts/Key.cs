using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoof;
	public Door door;

	void Update()
	{
		transform.Rotate (0, Time.deltaTime + 2, 0);
	}

	public void OnKeyClicked()
	{
		Instantiate (KeyPoof, transform.position, Quaternion.Euler(-90, transform.rotation.y, transform.rotation.z));
		Destroy (this.gameObject);
		door.Unlock ();
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }

}
