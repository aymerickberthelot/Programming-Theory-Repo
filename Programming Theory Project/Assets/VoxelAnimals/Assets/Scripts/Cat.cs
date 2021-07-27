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

        Name = "Little";
        Race = "Chicken";
        Age = 2;
        movementSpeed = 5;
    }

    public Cat()
    {
        Name = "Kitty";
        Race = "Cat";
        Age = 2;
        movementSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        this.ControllPlayer();
    }

    public override void Talk() //Polymorphism
    {
        Debug.Log("Hello I'm a " + Name + ", I'm Hello Kitty haha ! I am " + Age + " years old. Meow");
    }

    public override void Move(float cat_movementSpeed) //Polymorphism
    {
        base.Move(movementSpeed);
    }
}
