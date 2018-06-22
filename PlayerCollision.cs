using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag != "Obstacle" || TimeBody.isRewinding)
            return;
        {
            movement.enabled = false;
            TimeBody.isRewinding = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
