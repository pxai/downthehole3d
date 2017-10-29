using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    private Vector3 direction;
    private int speed = 1;

    void Start()
    {
    }

    void Update()
    {

        direction = this.GetComponent<Rigidbody>().velocity;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody>().velocity = (direction + Vector3.left) * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody>().velocity = (direction + Vector3.right) * speed;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().velocity = (direction + Vector3.forward) * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody>().velocity = (direction + Vector3.back) * speed;
        } 
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Boing....");
    }
}