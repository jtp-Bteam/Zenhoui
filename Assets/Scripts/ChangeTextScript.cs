using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextScript : MonoBehaviour {

	GameObject player;
    PlayerScript ps;

	GameObject mc;
	MainCameraScript mcs;

	private Text text;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(player == null) player = GameObject.Find("Player");
        if(ps == null) ps = player.GetComponent<PlayerScript>();
		if(mc == null) mc = GameObject.Find("Main Camera");
		if(mcs == null) mcs = mc.GetComponent<MainCameraScript>();
		text = this.GetComponent<Text>();
		switch(text.name){
			case "HP":
				text.text = "HP:" + ps.GetHP();
				break;
			case "Score":
				text.text = "SCORE:" + mcs.GetScore();
				break;
		}
	}
}
