using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    private Transform Player;
    public Vector3 offset;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update ()
    {
        transform.position = Player.position + offset;
	}
}
