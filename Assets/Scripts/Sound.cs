using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound Instance { get; private set; }

    public void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);// an sound already exists, remove this component

        }
        else
        {
            //if no sound try to find one
            Instance = FindAnyObjectByType<Sound>();
            if (Instance == null || Instance == this)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this);
            }
        }
    }
    public void PlaySoundEffects(AudioClip clip, AudioSource source)
    {
        //source.Play
    }
}
