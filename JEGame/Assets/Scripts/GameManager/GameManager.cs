using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    //Variables 
    public TextMeshProUGUI p1score;

    public TextMeshProUGUI p2score;

    public int p1sc_num;

    public int p2sc_num;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //Score on start = 0
        p1sc_num = 0;
        p2sc_num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        p1score.text = "Player 1 Score: " + p1sc_num;
        p2score.text = "Player 2 Score: " + p2sc_num;
    }
}
