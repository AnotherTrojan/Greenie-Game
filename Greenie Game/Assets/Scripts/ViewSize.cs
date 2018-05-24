using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSize : MonoBehaviour {
    private Camera camera;
	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
        camera.fieldOfView = 85;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
