using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public int themeNum;

    public AudioSource sourceBackground;
    public AudioSource soundEffect;

    public AudioClip[] clipBackground;
    public AudioClip[] explosion;
    public AudioClip[] score;
    public AudioClip[] shooting;

    public static Music instance;


    // Start is called before the first frame update
    void Start()
    {
        
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

    }




    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

}
