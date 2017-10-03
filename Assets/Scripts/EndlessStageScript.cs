using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessStageScript : AbstractStageScript {

    // [SerializeField]
    // GameObject playerObj;
    // [SerializeField]
    // GameObject enemyObj;
    // [SerializeField]
    // GameObject speedUpObj;
    // [SerializeField]
    // GameObject speedDownObj;
    // [SerializeField]
    // GameObject companionObj;
    // [SerializeField]
    // GameObject threeWayObj;

    // Use this for initialization
    public override void Start()
    {
        GameObject player = Instantiate(playerObj, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        player.name = "Player";
        int i;
        for (i = 0; i < 5; i++)
        {
            GameObject enemy = Instantiate(enemyObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity) as GameObject;
            enemy.name = "Enemy";
        }
        //InvokeRepeating("GenerateEnemy", 3f, 1f);
    }

    public override void FixedUpdate()
    {
        if (Random.value < 0.002) GenerateItem();
    }

    public override void GenerateEnemy()
    {
        GameObject enemy = Instantiate(enemyObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity) as GameObject;
        enemy.name = "Enemy";
    }

    public override void GenerateItem()
    {
        float rand = Random.value;
        if (rand < (1.0 / 4.0))
        {
            Instantiate(speedUpObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity);
        }
        else if (rand < (2.0 / 4.0))
        {
            Instantiate(speedDownObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity);
        }
        else if(rand < (3.0 / 4.0))
        {
            Instantiate(companionObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity);
        }
        else
        {
            Instantiate(threeWayObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity);
        }
    }
}
