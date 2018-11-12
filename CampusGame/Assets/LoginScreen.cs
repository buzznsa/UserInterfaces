using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoginScreen : MonoBehaviour {

    private string username = "username";
    private string password = "password";


    private string usernameEnter = string.Empty;
    private string passwordEnter = string.Empty;

    private Rect windowRect = new Rect(0, 0,Screen.width, Screen.height);

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.Window(0, windowRect, WindowFunction, "Login");
    }

    void WindowFunction (int windowID)
    {
        usernameEnter = GUI.TextField(new Rect(Screen.width/3, (2 * Screen.height/5), Screen.width/3, Screen.height/10), usernameEnter, 10);
        passwordEnter = GUI.PasswordField(new Rect(Screen.width/3, (2 * Screen.height/3), Screen.width/3, Screen.height/10), passwordEnter, "*"[0], 10);



        if(GUI.Button(new Rect(Screen.width/3, 4 * Screen.height/5, Screen.width/8, Screen.height/8), "Log-in"))
        {
           //if(usernameEnter == username && passwordEnter == password)
           if(usernameEnter.Length != 0 && passwordEnter.Length != 0)
           {

                Debug.Log("Welcome Roadrunner!");
           }
            else
            {
                Debug.Log("Not Correct");
            }
        }
        if (GUI.Button(new Rect(Screen.width / 1.85f, 4 * Screen.height / 5, Screen.width / 8, Screen.height / 8), "Main Menu"))
        {
            GameObject loginScreen = GameObject.Find("LoginScreen");
            loginScreen.SetActive(false);

            GameObject canvas = GameObject.Find("Canvas");
            GameObject MainMenu = canvas.transform.FindChild("StartPanel").gameObject;
            MainMenu.SetActive(true);

            //MainMenu.SetActive(true);
        }

        GUI.Label(new Rect(Screen.width / 3, (35 * Screen.height / 100), Screen.width/5, Screen.height/8), "Username");
        GUI.Label(new Rect(Screen.width / 3, (62 * Screen.height / 100), Screen.width / 8, Screen.height / 8), "Password");
    }
}
