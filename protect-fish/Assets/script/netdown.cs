using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netdown : MonoBehaviour
{

    public GameObject pullup;
    public float speed=0.3f;
    private float delay;
    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(8f, 30f);
    }

    // Update is called once per frame
    void Update()
    {

        float y = transform.position.y;
        Vector3 movement = new Vector3(0, y, 0);
        transform.Translate(movement * -speed * Time.deltaTime);

        StartCoroutine(timeDelay());
    }

    IEnumerator timeDelay()
    {

        yield return new WaitForSeconds(delay);
        var SpawnedNet = Instantiate(pullup, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }


}
