using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStageScript : MonoBehaviour {

	public void IntArgFunction(int num)
    {
		if(num == 0){
        	SceneManager.LoadScene("SelectStage");
		}
		else if(num == 1){
			// SceneManager.LoadScene("ReadyScene");
			SceneManager.LoadScene("EndlessStage");
		}
		else if(num == 2){
			SceneManager.LoadScene("AllScoreScene");
		}
		else{
			SceneManager.LoadScene("BackSide");
		}
    }
}
