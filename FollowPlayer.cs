using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform Player;
    public Vector3 offset;

	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.position + offset;
	}
}
