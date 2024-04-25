using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //the move speed of the player's ship
    public float moveSpeed = 5;
    //the horizontal input
    public float hInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the value of horizontal input
        hInput = Input.GetAxisRaw("Horizontal");

        //movement the player's ship
        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
    }
}
