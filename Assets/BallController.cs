using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    private GameObject gamescore;
    
    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //GameScoreを取得
        this.gamescore = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            Score += 10;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            Score += 20;
        }
        else if(other.gameObject.tag== "SmallCloudTag")
        {
            Score += 30;
        }
        else if(other.gameObject.tag== "LargeCloudTag")
        {
            Score += 40;
        }
        this.gamescore.GetComponent<Text>().text = "Score:" + Score;
    }
}