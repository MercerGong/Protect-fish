using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int baseSpeed;
    public int boostSpeed;
    int speed;
    Camera cam;
    Collider planeCollider;
    RaycastHit hit;
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        planeCollider = GameObject.Find("Background").GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            speed = boostSpeed;
        }else{
            speed = baseSpeed;
        }
        //transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, speed));
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit)){
            if(hit.collider == planeCollider){
                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime*speed);
                var mousePos = Input.mousePosition;
                mousePos.z = 10;
                //transform.LookAt(new Vector3(hit.point.x, tranform.position.y, hit.point.z));
                if(cam.ScreenToWorldPoint(mousePos).x < transform.position.x){
                    transform.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, transform.position.z));
                }else{
                    transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, transform.position.z));
                }
                Debug.Log("Text: " + transform.position.x + ", " + cam.ScreenToWorldPoint(mousePos).x);
            }
        }
    }
}
