using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractStageScript : MonoBehaviour {

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
    public virtual void Update () {
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
}
