using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //the move speed of the enemy ships
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement of enemy ships
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    //when enemies hit the boundary or other enemies, they go to the opposite horizontal direction
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundary" || collision.gameObject.tag == "Enemy") {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);

            moveSpeed *= -1;
        }
    }

}
