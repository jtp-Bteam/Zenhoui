using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour
{
    Vector3 pos;

    // Use this for initialization
    void Start () {
		pos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        pos.x += CrossPlatformInputManager.GetAxisRaw("HorizontalLeft") * 0.3f;
        pos.z += CrossPlatformInputManager.GetAxisRaw("VerticalLeft") * 0.3f;
        transform.position = pos;
        double radian = System.Math.Atan2(CrossPlatformInputManager.GetAxis("VerticalRight"), CrossPlatformInputManager.GetAxis("HorizontalRight"));
        int dosu = (int)((180 * radian) / System.Math.PI) - 90;
        transform.rotation = Quaternion.Euler(0, -dosu, 0);
    }
}
