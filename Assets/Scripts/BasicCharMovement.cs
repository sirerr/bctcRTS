using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharMovement : MonoBehaviour
{
    public float speed;
    public Animator anim;

    Rigidbody rbody;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }
    
    public void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        anim.SetFloat("mover", ver);
        if (Input.GetButtonDown("Jump"))
            anim.SetTrigger("jump");
    }
}
