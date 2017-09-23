using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

abstract public class AbstractMonoScript : MonoBehaviour, MonoScript
{
    protected int hp;
    protected int lastDosu = 0;
    protected int companionNum = 0; //味方の数

    protected float speed = 500f;
    protected float moveX = 0f, moveZ = 0f;

    [SerializeField]
    protected GameObject companion;
    [SerializeField]
    protected GameObject explodObj;

    // Use this for initialization
    public virtual void Start () {
        hp = 5;
    }

	// Update is called once per frame
	public virtual void Update () {
        Idou();
        Kaiten();
    }

    public virtual void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(moveX, 0, moveZ);
    }

    public virtual void Idou()
    {
        //ここはAndroid用なのでビルドの際は絶対に有効にし、下のを無効にする

        //moveX = CrossPlatformInputManager.GetAxisRaw("HorizontalLeft") * Time.deltaTime * speed;
        //moveZ = CrossPlatformInputManager.GetAxisRaw("VerticalLeft") * Time.deltaTime * speed;

        //Android用ここまで

        moveX = Input.GetAxisRaw("HorizontalLeft") * Time.deltaTime * speed;
        moveZ = Input.GetAxisRaw("VerticalLeft") * Time.deltaTime * speed;
    }

    public virtual void Kaiten()
    {
        //ここもIdouメソッドと同様にビルドの際は絶対に有効にする

        //double radian = System.Math.Atan2(CrossPlatformInputManager.GetAxis("VerticalRight"), CrossPlatformInputManager.GetAxis("HorizontalRight"));

        //Android用ここまで

        double radian = System.Math.Atan2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));


        int dosu = (int)((180 * radian) / System.Math.PI) - 90;
        if (CrossPlatformInputManager.GetAxis("VerticalRight") == 0 && CrossPlatformInputManager.GetAxis("HorizontalRight") == 0 && dosu == -270)
        {
            dosu = lastDosu;
        }
        else
        {
            lastDosu = dosu;
        }
        transform.rotation = Quaternion.Euler(0, -dosu, 0);
    }

    public virtual int GetHP()
    {
        return hp;
    }

    public virtual void IncreaseSpeed()
    {
        if(speed < 2000) speed += 500;
    }

    public virtual void DecreaseSpeed()
    {
        if(speed > 500) speed -= 500;
    }

    public virtual void AddCompanion()
    {
        if (companionNum < 4)
        {
            GameObject com = Instantiate(companion, transform.position, Quaternion.identity);
            com.GetComponent<CompanionScript>().Create(companionNum);
            companionNum++;
        }
    }

    public virtual void ApplyThreeWay()
    {
        gameObject.GetComponent<MyShootingScript>().ApplyThreeWay();
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            hp--;
            if (hp == 0)
            {
                Instantiate(explodObj, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
