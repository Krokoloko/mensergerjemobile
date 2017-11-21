using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonManager : MonoBehaviour {

    public GameObject settings;

    //Loads the scene from the StartLevel argument as room name.
    public void StartButton(string StartLevel)
	{
		SceneManager.LoadScene (StartLevel);
	}

    //Spawns the setting on the main menu.
    public void SpawnSettings()
    {
       GameObject spawned = Instantiate<GameObject>(settings,new Vector3(),Quaternion.identity);
    }
}
