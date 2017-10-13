using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectEquipmentScript : MonoBehaviour {

	public void StringArgFunction(string str)
    {
		switch(str){
			case "Back":
				SceneManager.LoadScene("StartStage");
				break;
            case "Go":
                SceneManager.LoadScene("EndlessStage");
                break;
            case "Shop":
                SceneManager.LoadScene("Shop");
                break;
            case "IncreaseSpeed":
                if(PlayerPrefs.GetInt("CurrentSpeed") < 3) PlayerPrefs.SetInt("CurrentSpeed", PlayerPrefs.GetInt("CurrentSpeed") + 1);
                break;
            case "DecreaseSpeed":
                if(PlayerPrefs.GetInt("CurrentSpeed") > 0)PlayerPrefs.SetInt("CurrentSpeed", PlayerPrefs.GetInt("CurrentSpeed") - 1);
                break;
            case "IncreaseBullet":
                if(PlayerPrefs.GetInt("CurrentBullet") < 3) PlayerPrefs.SetInt("CurrentBullet", PlayerPrefs.GetInt("CurrentBullet") + 1);
                break;
            case "DecreaseBullet":
                if(PlayerPrefs.GetInt("CurrentBullet") > 0) PlayerPrefs.SetInt("CurrentBullet", PlayerPrefs.GetInt("CurrentBullet") - 1);
                break;
            case "IncreaseCompanion":
                if(PlayerPrefs.GetInt("CurrentCompanion") < 5) PlayerPrefs.SetInt("CurrentCompanion", PlayerPrefs.GetInt("CurrentCompanion") + 1);
                break;
            case "DecreaseCompanion":
                if(PlayerPrefs.GetInt("CurrentCompanion") > 0) PlayerPrefs.SetInt("CurrentCompanion", PlayerPrefs.GetInt("CurrentCompanion") - 1);
                break;
        }
    }
}
