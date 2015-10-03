using UnityEngine;
using System.Collections;

public class navigate3 : MonoBehaviour {

	Transform target;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	public float Time = 50f;            // How long between each spawn.
	
	
	
	
	void Awake ()
	{
		// Set up the references.
		target = GameObject.FindGameObjectWithTag ("building2").transform;
		
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (target.position);
	}
	void Update ()
	{
		
		// ... set the destination of the nav mesh agent to the player.
		nav.SetDestination (target.position);
		InvokeRepeating ("Change", Time, Time);
		
	} 
	void Change()
	{
		target = GameObject.FindGameObjectWithTag ("dead").transform;
		
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (target.position);
	}
	
	
	
	//
	
	
	
	
	
}