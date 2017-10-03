//---注意---
//これは雑魚敵用スクリプトであり、汎用敵スクリプトではありません
//---注意ここまで---

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : AbstractMonoScript {

    [SerializeField]
    GameObject sparkObj;
    Transform player; //プレイヤーの場所とか
    MainCameraScript mcs;

	// Use th
	public override void Start () {
        hp = 10;
        speed = 2 + Random.value * 6;
        player = GameObject.Find("Player").transform;
        Instantiate(sparkObj, gameObject.transform.position, Quaternion.identity); //出現時のエフェクト
        mcs = GameObject.Find("Main Camera").GetComponent<MainCameraScript>();
    }
	
    public override void Idou(){
        //距離を保させたいならこちらを使う
        //if (Vector3.Distance(transform.position, player.position) > 5) GetComponent<Rigidbody>().velocity = gameObject.transform.forward * 5;
        //else GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

        //超接近させるならこっち
        GetComponent<Rigidbody>().velocity = gameObject.transform.forward * speed;
    }

    public override void Kaiten(){
        if (player) transform.LookAt(player);
    }

    public override void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MyBullet")
        {
            hp--;
            if (hp == 0)
            {
                Instantiate(explodObj, gameObject.transform.position, Quaternion.identity);
                mcs.AddScore();
                Destroy(gameObject);
            }
        }
    }
}
