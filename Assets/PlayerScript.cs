using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += CrossPlatformInputManager.GetAxisRaw("Horizontal") * 0.5f;
        pos.z += CrossPlatformInputManager.GetAxisRaw("Vertical") * 0.5f;
        transform.position = pos;
	}
}
