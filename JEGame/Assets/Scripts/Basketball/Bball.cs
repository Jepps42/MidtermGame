using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bball : MonoBehaviour
{

    public GameObject Ball;

    public static Bball Instance;

    private Vector2 Vector2 = Vector2.zero;

    private bool spawn = true;

    public Rigidbody2D Rigidbody;
    private void Awake()
    {
        Rigidbody = this.GetComponent<Rigidbody2D>();
        Ball = this.gameObject;
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            

            //Spawn the ball at the center 
            
            
        if (collision.transform.tag == "Hoop")
        {
            GameManager.instance.p1sc_num++;
            this.gameObject.transform.position = Vector2;
            this.gameObject.transform.SetParent(null);
        }
        
        if (collision.transform.tag == "Hoop2")
        {
            GameManager.instance.p2sc_num++;
            this.gameObject.transform.position = Vector2;
            this.gameObject.transform.SetParent(null);
        }
    }

   
}
