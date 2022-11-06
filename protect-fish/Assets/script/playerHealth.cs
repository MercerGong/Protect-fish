using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int Health=3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health < 0){
            Application.Quit();
        }
    }
}
