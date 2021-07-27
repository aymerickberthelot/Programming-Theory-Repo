using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAnimalHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public static SaveAnimalHandler Instance;
    public Animal animal;
    void Awake()
    {
        SaveInstance();
        //Debug.Log(Instance.animal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveInstance()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
