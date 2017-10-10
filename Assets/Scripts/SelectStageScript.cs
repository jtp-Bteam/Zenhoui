using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStageScript : MonoBehaviour {

    public void IntArgFunction(int num)
    {
        if(num == -1) SceneManager.LoadScene("StartStage");
        SceneManager.LoadScene("Stage" + num);
    }
}
