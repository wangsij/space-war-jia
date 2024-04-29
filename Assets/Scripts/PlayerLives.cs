using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{

    //lives of player's ship
    public int lives = 3;

    //number of lives of player ship's UI
    public Image[] livesUI;

    //the explosion prefab
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect when playr collides with enemies, subtract a life and a life in UI, end game when lives run out

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //in the situation when player ship collides with enemy
        if(collision.collider.gameObject.tag == "Enemy") {

            //play the explosion music
            Music.instance.playExplosion();

            //player loses one life
            Destroy(collision.collider.gameObject);
            lives -= 1;

            //explosion happens at the current location
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            //loop through all the UI images, adding or subtracting them based on curent health
            for(int i = 0; i < livesUI.Length; i++) {
                if(i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            
            }

            //when lives run out, destroy the player ship
            if(lives <= 0){
                Destroy(gameObject);
            }
        
        }
    }

}
