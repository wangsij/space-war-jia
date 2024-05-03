using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TitleManager : MonoBehaviour
{
    //public GameObject startGameFlag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void OnReturnClicked()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }
}
