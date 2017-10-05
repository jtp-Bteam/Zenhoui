using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class AbstractStageScript : MonoBehaviour {

    protected float time;

    [SerializeField]
    public GameObject playerObj;
    [SerializeField]
    public GameObject enemyObj;
    [SerializeField]
    public GameObject speedUpObj;
    [SerializeField]
    public GameObject speedDownObj;
    [SerializeField]
    public GameObject companionObj;
    [SerializeField]
    public GameObject threeWayObj;

    // Use this for initialization
    public virtual void Start()
    {
    }

    // Update is called once per frame
    public virtual void Update () 
    {
    }

    public virtual void FixedUpdate()
    {
    }

    public virtual void GenerateEnemy()
    {
    }

    public virtual void GenerateItem()
    {
    }

    public virtual void CountTime()
    {
        if(SceneManager.GetActiveScene().name == "EndlessStage"){
            time += Time.deltaTime;
        }
        else{
            if(time > 0) time -= Time.deltaTime;
        }
    }

    public virtual float GetTime(){
        return time;
    }
}
