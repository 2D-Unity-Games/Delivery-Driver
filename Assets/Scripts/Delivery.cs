using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
	[SerializeField] float destroyDelay;
	[SerializeField] Color32 hasPackageColor;
	[SerializeField] Color32 noPackageColor;
	
	bool hasPackage;
	SpriteRenderer spriteRenderer;
	
	private void Start() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	private void OnCollisionEnter2D(Collision2D other) 
	{
		Debug.Log("Im collided");
	}
	
	private void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Package" && !hasPackage)
		{
			Debug.Log("Package picked up");
			hasPackage = true;
			Destroy(other.gameObject, destroyDelay);
			spriteRenderer.color = hasPackageColor;
		}
		
		if (hasPackage && other.tag == "Customer")
		{
			Debug.Log("Package Delivered");
			hasPackage = false;
			spriteRenderer.color = noPackageColor;
		}
	}
}
