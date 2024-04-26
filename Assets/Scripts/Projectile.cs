using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //the move speed of the projectile
    public float moveSpeed;

    //the game object for the explosion animation
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement the pojectile
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //if hit projectile to enemy, play explosion, destroy enemy, and destroy the projectile
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        //if hit the boundary, destroy the projectile
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }


    }


}
