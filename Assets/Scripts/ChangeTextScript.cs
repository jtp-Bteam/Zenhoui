using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
		text = GetComponent<Text>();

		if(SceneManager.GetActiveScene().name == "SelectEquipment"){ //装備選択画面
			switch(text.name){
                case "CurrentSpeed":
                    text.text = (PlayerPrefs.GetInt("CurrentSpeed")).ToString();
                    break;
				case "CurrentBullet":
					text.text = (PlayerPrefs.GetInt("CurrentBullet")).ToString();
					break;
				case "CurrentCompanion":
					text.text = (PlayerPrefs.GetInt("CurrentCompanion")).ToString();
					break;
			}
		}

		else if(SceneManager.GetActiveScene().name == "ResultEndless"){
			
		}

		else{ //戦闘シーン全てに適用を予定
			if(player == null &&　GameObject.Find("Player")) player = GameObject.Find("Player");
			if(player == null && GameObject.Find("Player")) ps = player.GetComponent<PlayerScript>();
			if(mc == null) mc = GameObject.Find("Main Camera");
			if(mcs == null) mcs = mc.GetComponent<MainCameraScript>();
			if(ass == null) ass = stage.GetComponent<AbstractStageScript>();
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
}