using UnityEngine;
using System.Collections;

public class BuildingControl : MonoBehaviour {
	public bool moveBuild;
	public bool destroyBuil;
	private MoveBuilding movebuilding;
	private DestroyBuilding destroybuilding;
	// Use this for initialization
	void Start () {
		movebuilding = GetComponent<MoveBuilding> ();
		destroybuilding = GetComponent<DestroyBuilding> ();
		moveBuild = false;
		destroyBuil = false;
	}
	
	// Update is called once per frame
	void Update () {
	   if (Input.GetButtonDown ("Destroy")) {
			Debug.Log("Destroy");

		}
	}
}
