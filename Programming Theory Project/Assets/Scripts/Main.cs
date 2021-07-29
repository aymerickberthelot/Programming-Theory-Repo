using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Animal animal;
    // Start is called before the first frame update
    void Start()
    {
        animal = SaveAnimalHandler.Instance.animal;
        Instantiate(animal, new Vector3(0f, 0f, -6.5f), new Quaternion(0, 180, 0, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
