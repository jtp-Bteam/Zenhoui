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
        }
    }
}
