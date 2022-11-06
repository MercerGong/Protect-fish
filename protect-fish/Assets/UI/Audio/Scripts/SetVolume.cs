using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    public Slider SE;
    public Slider Main;
    public Slider BGM;
    public float bgmVolume;
    public float seVolume;

    private static SetVolume _instance;
    public static SetVolume Instance
    {
        get { return _instance; }
    }

    ////sutuo0518
    ////
    //[SerializeField] private GameObject ButtonMuteFlase;
    //[SerializeField] private GameObject ButtonMuteTrue;
    ////
    //public static bool MusicMuteFlag = false;//start music on
    //
    void Awake()
    {
        _instance = this;
    }


    //当音量变化时
    public void SetMain()
    {
        PlayerPrefs.SetFloat("Mvalue", Main.value);
        seVolume = SE.value * Main.value;
        bgmVolume = BGM.value * Main.value;
    }
    public void SetSE()
    {
        PlayerPrefs.SetFloat("SEvalue", SE.value);
        Main.value = PlayerPrefs.GetFloat("Mvalue");
        seVolume = SE.value * Main.value;
    }
    public void SetBGM()
    {
        PlayerPrefs.SetFloat("BGMvalue", BGM.value);
        bgmVolume = BGM.value * Main.value;
    }


    void Start()
    {
        seVolume = PlayerPrefs.GetFloat("seVolume");
        bgmVolume = PlayerPrefs.GetFloat("bgmVolume");
        
    }

    void Update()
    {
        if (SE != null)
        {
            SE.value = PlayerPrefs.GetFloat("SEvalue");
            BGM.value = PlayerPrefs.GetFloat("BGMvalue");
            Main.value = PlayerPrefs.GetFloat("Mvalue");
        }
        else
        {
            seVolume = PlayerPrefs.GetFloat("seVolume");
            bgmVolume = PlayerPrefs.GetFloat("bgmVolume");
        }
    }
}
