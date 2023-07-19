using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    //Static reference to the gameobject that we want to persist
    public static BGM instance;
    //public AudioSource source;
    //public AudioClip newApplicantClip;
    //public AudioClip hireClip;

    private void Awake()
    {
        //Make sure it persists
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Destroys accidental instances
            Destroy(gameObject);
        }
    }

    //public void NewApplicantSFX()
    //{
    //    Debug.Log("Audio test");
    //    source.PlayOneShot(newApplicantClip);
    //}
}
