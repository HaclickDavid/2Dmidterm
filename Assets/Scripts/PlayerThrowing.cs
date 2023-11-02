using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrowing : MonoBehaviour
{
    [SerializeField] GameObject cherry;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            GameObject newCherry = Instantiate(cherry, transform.position, Quaternion.identity);
            Rigidbody2D rb = newCherry.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-CherrySpeed(), 0);
        }
    }

    float CherrySpeed()
    {
        bool isFlipped = GetComponent<PlayerMovement>().sprite.flipX;
        
        if (isFlipped) {
            return 20f;
        }

        return -20f;
    }
}