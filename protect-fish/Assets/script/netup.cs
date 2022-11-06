using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netup : MonoBehaviour
{
    public float speed=0.3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        Vector3 movement = new Vector3(0, y, 0);
        transform.Translate(movement * speed * Time.deltaTime);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);

        }
    }
}
