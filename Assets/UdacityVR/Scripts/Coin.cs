using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinPoof;

	void Update()
	{
		transform.Rotate (0, Time.deltaTime + 2, 0);
	}

    public void OnCoinClicked() {

		Instantiate (CoinPoof, transform.position, Quaternion.Euler(-90, transform.rotation.y, transform.rotation.z));
		Destroy (this.gameObject);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
