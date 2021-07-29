using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();

        Name = "Little";
        Race = "Chicken";
        Age = 2;
        movementSpeed = 1;
        jumpForce = 200;
        IntroduceYourselfText = "Chuck Chuck ! My name is " + Name + ", I'm a chicken.\n So I am Little Chicken haha. And I am " + Age + " years old.";
    }


    // Update is called once per frame
    void Update()
    {
        this.ControllPlayer();
    }


    public override void Move(float chicken_movementSpeed) //Polymorphism
    {
        base.Move(movementSpeed);
    }
}
