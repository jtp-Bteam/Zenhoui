using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroStageScript : AbstractStageScript {

    GameObject bossObj;

	// Use this for initialization
	void Start () {

        playerObj = (GameObject)Resources.Load("Prefabs/Player");
        bossObj = (GameObject)Resources.Load("Prefabs/SearchAndDestroy");

        GameObject player = Instantiate(playerObj, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        player.name = "Player";

        //GenerateEnemy();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void GenerateEnemy()
    {
        GameObject enemy = Instantiate(enemyObj, new Vector3(-20 + Random.value * 40, 0, -20 + Random.value * 40), Quaternion.identity) as GameObject;
        enemy.name = "Enemy";
    }

    public void GenerateBoss()
    {
        Destroy(GameObject.Find("GyroObstacle"));
        GameObject boss = Instantiate(bossObj, new Vector3(-14, 0, 14), Quaternion.identity);
        boss.name = "Enemy";
    }
}
