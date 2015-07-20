using UnityEngine;
using System.Collections;

public class cameraBehavior : MonoBehaviour 
{

	public GameObject cameraCube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		cameraCube.transform.position += new Vector3 (0.55f, 0f, 0f) * Time.deltaTime;
		//cameraCube.transform.position += new Vector3 ((0.0f, -0.5f, 0f) * Time.time > 5f);
	}
}
