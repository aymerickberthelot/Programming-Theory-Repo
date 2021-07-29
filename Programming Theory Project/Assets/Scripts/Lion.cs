using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEditor.Events;

public class Lion : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();

        Name = "Musafa";
        Race = "Lion";
        Age = 20;
        movementSpeed = 12;
        jumpForce = 400;
        IntroduceYourselfText = "Roarrrrr ! My name is " + Name + ",\n I'm a "+ Age+" years old Lion King";
    }

    // Update is called once per frame
    void Update()
    {
        this.ControllPlayer();
    }


    public override void Move(float lion_movementSpeed) //Polymorphism
    {
        base.Move(movementSpeed);
    }

    
}
