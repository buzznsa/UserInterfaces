using Anonym.Isometric;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour {

    public GameObject EntryPanel;
    public string loadLevel;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider col)//If player hits trigger box, open the panel to enter building
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided");
            EntryPanel.SetActive(true);
            Debug.Log(SceneManager.GetActiveScene().name);
            if (Input.GetKeyUp(KeyCode.Return))//If the user presses ENTER, load the building
            {
               SceneManager.LoadScene(loadLevel);
            }
            else if(IsometricNavMeshAgent.FindingRoom)//The user character is already looking for a room, 
                                                      //load the scene automatically
            {
                SceneManager.LoadScene(loadLevel);
            }
        }
    }

    void OnTriggerExit()//If user exits trigger box, deactivate the panel
    {
        EntryPanel.SetActive(false);
    }

}
