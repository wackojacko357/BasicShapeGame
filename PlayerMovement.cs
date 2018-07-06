using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    public float ForwardForce = 2000f;
    public float sidewaysForce = 0.2f;
    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
            transform.Translate(Input.acceleration.x, 0, 0);

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
