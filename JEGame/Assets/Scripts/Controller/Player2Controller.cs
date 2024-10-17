using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    //Variables
    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find the object every frame 
        Vector2 pos = transform.position;

        //Press right arrow to move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }

        //Press left arrow to move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //Press up arrow to move up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
        
        //Press down arrow to move down
        if (Input .GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }

        transform.position = pos;

        if (Input.GetKey(KeyCode.RightShift))
        {

            Vector2 shotHeight = new Vector2(-5, 10); 
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
