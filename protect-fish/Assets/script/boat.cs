using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3.0f;
    private bool back = false;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (gameObject.transform.position.x > 5)
        {
            back = true;
        }
        else if (gameObject.transform.position.x < -5)
        {
            back = false;
        }

        if (back == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + -speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }

    }
}