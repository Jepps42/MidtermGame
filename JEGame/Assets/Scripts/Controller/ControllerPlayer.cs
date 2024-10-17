using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{

    //Variables 
    public float speed = 4f;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find the position of the object every frame and make a vector
        Vector2 pos = transform.position;

        //Press D, move to the right
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        //Press A to move to the left
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //Press S to move down
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        //Press W to move up
        if(Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        //Must have line in order for transform postion to work
        transform.position = pos;

        if (Input.GetKey(KeyCode.E)) 
        {
            Vector2 shotHeight = new Vector2(10, 6);
            Bball.Instance.Rigidbody.velocity = pos + shotHeight;
            Bball.Instance.transform.SetParent(null);
            Bball.Instance.Rigidbody.gravityScale = 1;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.tag == "Ball")
        {
            Bball.Instance.transform.SetParent(this.transform);
            Bball.Instance.Rigidbody.gravityScale = 0;
            Bball.Instance.Rigidbody.velocity = Vector2.zero;
        }
    }
}
