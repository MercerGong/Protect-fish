using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour
{
    private float time=0f;
    private float timepull;
    public GameObject model1;
    public GameObject model2;
    private GameObject currentModel;

    void Start()
    {
        timepull = Random.Range(1, 2);
        currentModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 1);
    }

    private void OnCollisionEnter(Collision collision)// when collied with player what happened
    {



    }

    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        while (time < timepull)//after a certain amount of time, the model is switched and the net is being pulled upward.
        {


        }

        ChangeModel2();

        if (gameObject.transform.position.y < -4)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y > 4)
        {
            Destroy(gameObject);
        }


    }

    public void ChangeModel2()
    {

            GameObject thisModel = Instantiate(model2, transform.position, transform.rotation) as GameObject;
            Destroy(currentModel);



        
    }

}
