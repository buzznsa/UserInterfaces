using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour 
{

    public void GotoMainScene()
    {
        SceneManager.LoadScene("7.1CharacterControllers");
    }
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

