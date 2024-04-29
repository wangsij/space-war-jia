using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public int themeNum;

    public AudioSource sourceBackground;
    public AudioSource soundEffect;
    public AudioSource explosionEffect;


    //the four arrays that each store three themes of music
    public AudioClip[] clipBackground;
    public AudioClip[] explosion;
    public AudioClip[] score;
    public AudioClip[] shooting;

    //the current music effect that should be played
    public AudioClip currentExplosion;
    public AudioClip currentScore;
    public AudioClip currentShooting;

    //manager instance to make sure it is the only instance in the environment
    public static Music instance;


    // Start is called before the first frame update
    void Start()
    {
        switchMusicTheme(0);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1)) {

            switchMusicTheme(0);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {

            switchMusicTheme(1);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {

            switchMusicTheme(2);
        }

    }



    public void switchMusicTheme(int themeNum)
    {
        //switch to the correct source background
        sourceBackground.clip = clipBackground[themeNum];
        sourceBackground.Play();

        currentExplosion = explosion[themeNum];
        currentScore = score[themeNum];
        currentShooting = shooting[themeNum];

    }

    public void playExplosion()
    {
        explosionEffect.clip = currentExplosion;
        explosionEffect.Play();
    }

    public void playScore()
    {
        Debug.Log("GetScore");
        soundEffect.clip = currentScore;
        soundEffect.Play();
    }

    public void playShooting()
    {
        Debug.Log("GetShoot");
        soundEffect.clip = currentShooting;
        soundEffect.Play();
    }


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

}
