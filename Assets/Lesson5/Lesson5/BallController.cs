using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject scoreText;
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score" + this.score;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
            this.scoreText.GetComponent<Text>().text = "Score" + this.score;
        }
    }

    void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 30;
        }

        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }

        else if (other.gameObject.tag == "SmallStarTag")
        { 
            this.score += 10;
        }

        this.scoreText.GetComponent<Text>().text = "Score" + this.score;


    }



}
