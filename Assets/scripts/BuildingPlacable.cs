﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BuildingPlacable : MonoBehaviour {
	[HideInInspector]
	public List<Collider> colliders=new List<Collider>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider c){
		if (c.tag == "building")
			colliders.Add (c);
	}
	void OnTriggerExit(Collider c){
		if (c.tag == "building")
			colliders.Remove (c);
	}
}
