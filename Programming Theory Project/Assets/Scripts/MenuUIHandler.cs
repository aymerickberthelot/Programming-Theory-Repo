using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject lion;
    public GameObject cat;
    public GameObject dog;
    public GameObject chicken;

    private Lion l;
    private Cat c;
    private Dog d;
    private Chicken ch;



    // Start is called before the first frame update
    void Start()
    {
        l = lion.GetComponent<Lion>();
        c = cat.GetComponent<Cat>();
        d = dog.GetComponent<Dog>();
        ch = chicken.GetComponent<Chicken>();
    }

    public void QuitGame()
    {
        //EditorApplication.ExitPlaymode();
        Application.Quit();
    }

    public void ChooseAnimalButton()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Lion")
        {
            SaveAnimalHandler.Instance.animal = l;
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "Cat")
        {
            SaveAnimalHandler.Instance.animal = c;
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "Dog")
        {
            SaveAnimalHandler.Instance.animal = d;
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "Chicken")
        {
            SaveAnimalHandler.Instance.animal = ch;
        }

        LaunchMain();

    }

    private void LaunchMain()
    {
        SceneManager.LoadScene(1);
    }
}
