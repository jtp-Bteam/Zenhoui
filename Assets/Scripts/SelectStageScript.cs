using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStageScript : MonoBehaviour {

    public void IntArgFunction(int num)
    {
        Debug.Log("IntArgFunction");
        SceneManager.LoadScene("Stage" + num);
    }
}
