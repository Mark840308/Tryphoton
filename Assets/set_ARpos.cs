using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_ARpos : MonoBehaviour {

	public GameObject AR_camera;
	private int framecount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		framecount++;
		if (framecount % 2 == 0)
			AR_camera.transform.position = transform.position;
	}
}
