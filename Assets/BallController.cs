using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;
    private GameObject gamescore;
    
    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //GameScore���擾
        this.gamescore = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
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