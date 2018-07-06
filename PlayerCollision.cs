using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    private PlayerMovement movement;
    public GameObject completeLevelUI;

    private void Start()
    {
        movement = gameObject.GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag != "Obstacle" || TimeBody.isRewinding)
            return;
        {
            movement.enabled = false;
            TimeBody.isRewinding = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag != "Finish")
            return;
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        completeLevelUI.SetActive(true);
    }
}
