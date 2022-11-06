using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainSys.Audio
{
    public class ResetVolume : MonoBehaviour
    {

        void Awake()
        {
            PlayerPrefs.SetFloat("SEvalue", 1);
            PlayerPrefs.SetFloat("BGMvalue", 1);
            PlayerPrefs.SetFloat("Mvalue", 1);
            PlayerPrefs.SetFloat("seVolume", 1);
            PlayerPrefs.SetFloat("bgmVolume", 1);
            //Destroy(gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
