using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextScript : MonoBehaviour {

	GameObject player;
    PlayerScript ps;

	GameObject mc;
	MainCameraScript mcs;

	[SerializeField]
	GameObject stage;
	AbstractStageScript ass;

	private Text text;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("Player")) player = GameObject.Find("Player");
        if(GameObject.Find("Player")) ps = player.GetComponent<PlayerScript>();
		if(mc == null) mc = GameObject.Find("Main Camera");
		if(mcs == null) mcs = mc.GetComponent<MainCameraScript>();
		if(ass == null) ass = stage.GetComponent<AbstractStageScript>();
		text = this.GetComponent<Text>();
		switch(text.name){
			case "HP":
				if(GameObject.Find("Player") == false) text.text = "HP:0";
				else text.text = "HP:" + ps.GetHP();
				break;
			case "Time":
				text.text = "Time:" + (int)ass.GetTime();
				break;
			case "Score":
				text.text = "SCORE:" + mcs.GetScore();
				break;
		}
	}
}
