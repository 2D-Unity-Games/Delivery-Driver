using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
	bool hasPackage;
	
	private void OnCollisionEnter2D(Collision2D other) {
		Debug.Log("Im collided");
	}
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Package")
		{
			Debug.Log("Package picked up");
			hasPackage = true;
		}
		
		if (hasPackage && other.tag == "Package")
		{
			Debug.Log("Im triggered");
			hasPackage = false;
		}
	}
}
