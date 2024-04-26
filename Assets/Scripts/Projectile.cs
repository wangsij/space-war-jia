using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //the move speed of the projectile
    public float moveSpeed;

    //the game object for the explosion animation
    public GameObject explosionPrefab;

    //a private point manager to keep track of the points
    private PointManager pointManager;

    // Start is called before the first frame update
    void Start()
    {
        //find the point manager
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement the pojectile
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //if a projectile is hit to enemy, play explosion, destroy enemy, update points, and destroy the projectile
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }

        //if hit the boundary, destroy the projectile
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }


    }


}
