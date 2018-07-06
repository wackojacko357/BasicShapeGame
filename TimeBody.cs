using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour 
{
    public static bool isRewinding = false;

    List<Vector3> positions;

    // Use this for initialization
    void Start ()
    {
        positions = new List<Vector3>();
	}

    private void FixedUpdate()
    {
        if (isRewinding)
            Rewind();
        else
            Record();
    }

    void Rewind()
    {
        transform.position = positions[0];
        positions.RemoveAt(0);
    }

    void Record()
    {
        positions.Insert(0, transform.position);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Space))
            StopRewind();
        //Pc mb1 to rewind & mobile on touch
        if (Input.GetMouseButtonDown(0))
        {
            StartRewind();
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopRewind();
        }
    }

    public void StartRewind ()
    {
        isRewinding = true;
	}

    public void StopRewind ()
    {
        isRewinding = false;
    }
}
