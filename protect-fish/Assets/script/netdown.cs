using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netdown : MonoBehaviour
{

    public GameObject pullup;
    public float speed=0.6f;
    private float delay;
    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(3f, 10f);
        StartCoroutine(timeDelay());
    }

    // Update is called once per frame
    void Update()
    {

        float y = transform.position.y;
        Vector3 movement = new Vector3(0, y, 0);
        transform.Translate(movement * -speed * Time.deltaTime);

       
    }

    IEnumerator timeDelay()
    {

        yield return new WaitForSeconds(delay);
        var SpawnedNet = Instantiate(pullup, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
        }

    }

}
