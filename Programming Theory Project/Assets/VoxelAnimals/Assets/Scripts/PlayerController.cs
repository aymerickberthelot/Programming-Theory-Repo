﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEditor.Events;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 3;
    public float jumpForce = 300;
    public float timeBeforeNextJump = 1.2f;
    public float canJump = 0f;
    public Animator anim;
    public Rigidbody rb;

    public AudioSource playerAudioSource;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        ControllPlayer();
    }

    public void ControllPlayer()
    {
        Move(movementSpeed);  
        if (Input.GetButtonDown("Jump") && Time.time > canJump)
            Jump(); 

    }

    public void Jump() //Abstraction
    {
        rb.AddForce(0, jumpForce, 0);
        canJump = Time.time + timeBeforeNextJump;
        anim.SetTrigger("jump");
    }

    public virtual void Move(float movementSpeed) //Abstraction
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
            anim.SetInteger("Walk", 1);
        }
        else 
            anim.SetInteger("Walk", 0);
        

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

    }

    
}