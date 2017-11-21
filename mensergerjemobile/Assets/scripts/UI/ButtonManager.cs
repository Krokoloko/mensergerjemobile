using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ButtonManager : MonoBehaviour {

    public GameObject playerField;

    //Loads the scene from the StartLevel argument as room name.
    public void StartButton(string StartLevel)
	{

		SceneManager.LoadScene (StartLevel);
	}

    public void SaveSetting()
    {
        GameObject objectIns = Instantiate<GameObject>(new GameObject("datafromMenu"));
        SaveSettings data = objectIns.AddComponent<SaveSettings>();
        data.players = playerField.GetComponent<Text>().text;
        DontDestroyOnLoad(objectIns);
    }
}
