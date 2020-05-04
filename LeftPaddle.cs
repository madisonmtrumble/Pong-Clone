using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddle : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 1.0f, 0.0f);
            gameObject.GetComponent<Rigidbody>().velocity *= speed;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, -1.0f, 0.0f);
            gameObject.GetComponent<Rigidbody>().velocity *= speed;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
