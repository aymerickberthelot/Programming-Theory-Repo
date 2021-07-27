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

        Name = "Little";
        Race = "Dog";
        Age = 4;
        movementSpeed = 5;
    }


    // Update is called once per frame
    void Update()
    {
        this.ControllPlayer();
    }

    public override void Talk() //Polymorphism
    {
        Debug.Log("Woof woof! My name is " + Name + ", I'm a dog and I am " + Age + " years old.");
    }

    public override void Move(float dog_movementSpeed) //Polymorphism
    {
        base.Move(movementSpeed);
    }
}
