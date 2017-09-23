using UnityEngine;
using System.Collections;

public class EnemyShootingScript : AbstractShootingScript
{

    // Use this for initialization
    public override void Start()
    {
        if (gameObject.name == "Enemy")
        {
            InvokeRepeating("Shoot", Random.value, 1f);
            speed = 500 * Time.deltaTime;
        }
    }
}