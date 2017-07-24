using UnityEngine;
using System.Collections;

public class EnemyShootingScript : MyShootingScript
{

    // Use this for initialization
    void Start()
    {
        if (gameObject.name == "Enemy")
        {
            InvokeRepeating("Shoot", Random.value, 1f);
            speed = 500 * Time.deltaTime;
        }
    }
}