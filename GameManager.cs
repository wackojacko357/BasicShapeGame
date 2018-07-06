using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    private bool gameHasEnded = false;
    private float restartDelay = 1f;
    private Score theScore;

    public void Start()
    {
        theScore = FindObjectOfType<Score>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("restart", restartDelay);
            theScore.scoreIncreasing = false;
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        theScore.scoreCount = 0;
        theScore.scoreIncreasing = true;
    }
}
