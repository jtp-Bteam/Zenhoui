using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour {

    [SerializeField]
    GameObject playerObj;
    [SerializeField]
    GameObject enemyObj;
    [SerializeField]
    GameObject speedUpObj;
    [SerializeField]
    GameObject speedDownObj;
    [SerializeField]
    GameObject companionObj;
    [SerializeField]
    GameObject threeWayObj;

    // Use this for initialization
    void Start()
    {
        if (gameObject.name == "Stage1")
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
    }

    // Update is called once per frame
    void Update () {
	}

    private void FixedUpdate()
    {
        if (Random.value < 0.002) GenerateItem();
    }

    void GenerateEnemy()
    {
        GameObject enemy = Instantiate(enemyObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity) as GameObject;
        enemy.name = "Enemy";
    }

    void GenerateItem()
    {
        float rand = Random.value;
        if (rand < (1.0 / 4.0))
        {
            Instantiate(speedUpObj, new Vector3(Random.value * 46 + 2, 0, Random.value * 46 + 2), Quaternion.identity);
        }
        else if (rand < (2.0 / 4.0))
        {
            Instantiate(speedDownObj, new Vector3(Random.value * 46 + 2, 0, Random.value * 46 + 2), Quaternion.identity);
        }
        else if(rand < (3.0 / 4.0))
        {
            Instantiate(companionObj, new Vector3(Random.value * 46 + 2, 0, Random.value * 46 + 2), Quaternion.identity);
        }
        else
        {
            Instantiate(threeWayObj, new Vector3(Random.value * 46 + 2, 0, Random.value * 46 + 2), Quaternion.identity);
        }
    }
}
