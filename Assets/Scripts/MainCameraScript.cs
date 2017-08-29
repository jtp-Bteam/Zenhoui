using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{

    GameObject player;
    PlayerScript ps;
    public GUIStyle style;
    Vector2 guiScreenSize = new Vector2(1920, 1080); // 基準とする解像度
    int crushEnemyNum = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        ps = player.GetComponent<PlayerScript>();
        FollowPlayer();
    }

    private void OnGUI()
    {
        DisplayHP();
        DisplayScore();
    }

    private void DisplayHP()
    {
        GUIUtility.ScaleAroundPivot(new Vector2(Screen.width / guiScreenSize.x, Screen.height / guiScreenSize.y), Vector2.zero);
        GUI.Label(new Rect(10, 40, 1, 1), "HP:" + ps.GetHP().ToString(), style);
        GUI.matrix = Matrix4x4.identity;
    }

    private void DisplayScore()
    {
        GUIUtility.ScaleAroundPivot(new Vector2(Screen.width / guiScreenSize.x, Screen.height / guiScreenSize.y), Vector2.zero);
        GUI.Label(new Rect(1650, 40, 1, 1), "スコア:" + crushEnemyNum.ToString(), style);
        GUI.matrix = Matrix4x4.identity;
    }

    private void FollowPlayer()
    {
        if (player)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 20, player.transform.position.z - 4);
        }
    }

    public void AddCrushEnemyNum()
    {
        crushEnemyNum++;
    }

}
