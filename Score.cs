using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Transform player;
    private Text scoreText;
    private Text highScoreText;

    public float scoreCount;
    private float highScoreCount;

    public bool scoreIncreasing;


   public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        highScoreText = GameObject.Find("HighScore").GetComponent<Text>();
        scoreCount = 1f;
        if(PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }
     
    void Update ()
    {
        if (scoreIncreasing && !TimeBody.isRewinding)
        {
            scoreCount += 2f * Time.deltaTime;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        } 

        scoreText.text = " " + Mathf.Round (scoreCount);
        highScoreText.text = "HighScore: " + Mathf.Round (highScoreCount);

        player.position.z.ToString("0");
    }
}


