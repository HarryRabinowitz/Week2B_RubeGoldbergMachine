using UnityEngine;
using System.Collections;

public class particleSystemBehavior : MonoBehaviour
{


	public GameObject particleEmission;
	bool haveITriggered = false;
	
	//void OnTriggerEnter (Collider other)
	//{
	//	Debug.Log ("Object Entered the trigger");
	//	enableEmission = true;



	void OnTriggerEnter ()
	{
		haveITriggered = true;
	}

	// Use this for initialization
	void Start ()
	{
		particleEmission.SetActive (false);
	}



	
	// Update is called once per frame
	void Update ()
	{
		if (haveITriggered == true) {
			particleEmission.SetActive (true);
		}
	
	}

}


