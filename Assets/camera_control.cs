using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 20.0f, Space.World);
    }
}
