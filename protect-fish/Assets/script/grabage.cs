using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
       

        if (collision.gameObject.tag == ("Player"))
        {
            player.GetComponent<playerHealth>().Health -= 1;
            Debug.Log("destory");
            Destroy(gameObject);
        }

    }
}
