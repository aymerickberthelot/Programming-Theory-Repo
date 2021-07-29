using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VikingCrew.Tools.UI;

public class Animal : PlayerController
{

    private string _name;
    private string race;
    private int age;
    public string introduceYourselfText;

    public AudioClip talkSound;


    //----------------
    public Transform mouth;


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
        playerAudioSource = GetComponent<AudioSource>();
    }

    /*Polymorphism*/
    public void IntroduceYourself(string message)
    {
        IntroduceYourself(message, SpeechBubbleManager.Instance.GetFirstSpeechbubbleType());
    }

    public void IntroduceYourself(string message, SpeechBubbleManager.SpeechbubbleType speechbubbleType) //Polymorphism
    {
        if (mouth == null)
            SpeechBubbleManager.Instance.AddSpeechBubble(transform, message, speechbubbleType);
        else
            SpeechBubbleManager.Instance.AddSpeechBubble(mouth, message, speechbubbleType);
    }
    /*Polymorphism*/


    public override void Move(float movementSpeed) //Abstraction and Inheritance
    {
        base.Move(movementSpeed);
    }

    public void Talk() //Abstraction
    {
        GameObject speechText = GameObject.FindWithTag("SpeechText");

        if (speechText == null)
        {
            IntroduceYourself(introduceYourselfText);
            playerAudioSource.PlayOneShot(talkSound);
        }

        else if (speechText != null && !speechText.activeSelf)
        {
            IntroduceYourself(introduceYourselfText);
            playerAudioSource.PlayOneShot(talkSound);
        }
    }


    void OnMouseDown()
    {
        Talk();
    }

}
