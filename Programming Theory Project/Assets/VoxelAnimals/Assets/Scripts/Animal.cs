using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : PlayerController
{
    private string _name;
    private string race;
    private int age;


    //ENCAPSULATION
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.Length > 12)
                Debug.LogError("Name length is too long.");
            else
                _name = value;
        }

    }

    public string Race
    {
        get
        {
            return race;
        }
        set
        {
            if (value.Length > 20)
                Debug.LogError("Race length is too long.");
            else
                race = value;
        }

    }

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
                Debug.LogError("Age can't be negative.");
            else
                age = value;
        }

    }
    //ENCAPSULATION

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }



    public override void Move(float movementSpeed) //Abstraction and Polymorphism
    {
        base.Move(movementSpeed);
    }

    public virtual void Talk() //Abstraction and Polymorphism
    {

    }


    void OnMouseDown()
    {
        Talk();
    }

    /*public IEnumerator WaitToTalkAgain(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }*/
}
