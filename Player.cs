using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 50;
    public float jumpPower = 150;

    public bool grounded;

    private Rigidbody2D rb2d;


  
    void Start()
    {
        rb2d = GameObject GetComponet* Rigidbody2D(); 
    }

    void Update()
    {


        
    }
}
