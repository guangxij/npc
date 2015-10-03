using UnityEngine;
using System.Collections;

public class DestroyBuilding : MonoBehaviour {

	void Start () {

	}
	
	// Update is called once per frame

	void OnMouseDown(){

			Destroy (gameObject);
			
		}
}
