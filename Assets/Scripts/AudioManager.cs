using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    //Main Menu variables
    public AudioSource startButton;
    public AudioSource quitButton;
    //Game variables
    public AudioSource hireButton;
    public AudioSource nextApplicantButton;
    public AudioSource mainMenuButton;

    private void Awake()
    {
        //Make sure it persists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
        public void StartButton()
    {
        startButton.Play();
    }
    public void QuitButton()
    {
        quitButton.Play();
    }

    public void HireButton()
    {
        hireButton.Play();
    }
    public void NextApplicantButton()
    {
        nextApplicantButton.Play();
    }
    public void MainMenuButton()
    {
        mainMenuButton.Play();
    }

}
