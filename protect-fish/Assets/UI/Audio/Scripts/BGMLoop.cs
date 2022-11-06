using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMLoop : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {

    }
}
