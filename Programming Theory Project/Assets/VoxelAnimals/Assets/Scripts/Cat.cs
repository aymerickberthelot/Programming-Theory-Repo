using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();

        Name = "Kitty";
        Race = "Cat";
        Age = 2;
        movementSpeed = 5;
        introduceYourselfText = "Hello Im " + Name + ", that makes me Hello Kitty haha ! \n I am " + Age + " years old. Meow";
    }

    // Update is called once per frame
    void Update()
    {
        this.ControllPlayer();
    }


    public override void Move(float cat_movementSpeed) //Polymorphism
    {
        base.Move(movementSpeed);
    }
}
