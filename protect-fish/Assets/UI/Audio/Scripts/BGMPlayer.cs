using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMPlayer : MonoBehaviour
{
    public AudioSource music;
    public Slider BGM;
    public Slider Main;
    public GameObject BGMprefab;//该预制物体；
    private GameObject musicInstant = null;//用来判断是否存在

    private void Awake()
    {
        //_BGM_Track = GetComponentInChildren<AudioSource>();
    }

    //播放声音
    public void PlayBGM(string bgm_name)
    {
        music.loop = true;
        music.Play();
    }
    //停止播放
    public void StopBGM()
    {
        music.Stop();
        music.clip = null;
    }

    void Start()
    {
        music.volume = SetVolume.Instance.seVolume;

        Debug.Log(GameObject.FindGameObjectWithTag("Finish"));
        GameObject.FindGameObjectWithTag("Finish").SetActive(true);
        musicInstant = GameObject.FindGameObjectWithTag("sound");//寻找是否有带此tag的物体
        Debug.Log(musicInstant);
        if (musicInstant != null)
        {
            GameObject.FindGameObjectWithTag("Finish").SetActive(false);

            //musicInstant.SetActive(false);
            //musicInstant = (GameObject)Instantiate(BGMprefab);//如果这个页面没有新的BGM（默认使用上一场景的）
        }
    }


    void Update()
    {
        music.volume = SetVolume.Instance.seVolume;
    }
}


