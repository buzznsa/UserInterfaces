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

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided");
            EntryPanel.SetActive(true);
            if (Input.GetKeyUp(KeyCode.Return) || IsometricNavMeshAgent.FindingRoom)
            {
               SceneManager.LoadScene(loadLevel);
            }
        }
    }

    void OnTriggerExit()
    {
        EntryPanel.SetActive(false);
    }

}
