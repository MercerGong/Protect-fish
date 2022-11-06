using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MainSys.Audio
{
    public class SEPlayer : MonoBehaviour
    {
        public AudioClip clip;    //findclip()
        public AudioSource music;

        private static SEPlayer _instance;
        public static SEPlayer Instance
        {
            get { return _instance; }
        }
        void Awake()
        {
            _instance = this;
        }


        //拿到该音乐片段
        [Serializable]
        public class SoundEffectDict
        {
            public string _Name;
            public AudioClip _Clip;
        }
        public List<SoundEffectDict> _SoundEffectList;

        public AudioClip FindClip(string seName)
        {
            for (int i = 0; i < _SoundEffectList.Count; i++)
            {
                SoundEffectDict se = _SoundEffectList[i];
                if (se._Name == seName)
                {
                    return se._Clip;
                }
            }
            return null;
        }

        

        //播放SE
        public void PlaySE(string seName)
        {
            clip = FindClip(seName);
            Debug.Log(clip);
            if (clip != null)
            {
                music.clip = clip;
                music.Play();
                Debug.Log(music.volume);
            }
        }

        //当测试音量时停止播放背景音乐
        public void StopBGM()
        {
            music.Stop();
            music.clip = null;
        }



        void Start()
        {
            //Debug.Log(music.volume);
        }

        void Update()
        {
            //
            //if (Input.GetButtonDown("Submit"))
            //{
            //    //Debug.Log("Submit");
            //    //SceneManager.LoadScene("2_Menu");
            //}
        }

    }
}

