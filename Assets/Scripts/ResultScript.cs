using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScript : MonoBehaviour {
	public void BoolArgFunction(bool b){
		SceneManager.LoadScene("SelectStage");
	}
}
