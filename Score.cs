using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    private float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;


   public void Start()
    {
        if(PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }
     
    void Update ()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond = 2f * Time.deltaTime;
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


