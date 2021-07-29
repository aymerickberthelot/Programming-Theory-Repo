using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();

        Name = "Snoop";
        Race = "Dog";
        Age = 4;
        movementSpeed = 5;
        IntroduceYourselfText = ("Woof woof! My name is " + Name + ",\n I'm a dog and I am " + Age + " years old.");
    }


    // Update is called once per frame
    void Update()
    {
        this.ControllPlayer();
        
    }


    public override void Move(float dog_movementSpeed) //Polymorphism
    {
        base.Move(movementSpeed);
    }
}
