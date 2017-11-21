using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    /// <summary>
    /// This script manages the main menu and stores the amount of players chosen
    /// </summary>

    public static ButtonManager Instance
    {
        get;
        set;
    }

    public int players = 2;
    [SerializeField]


    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        Instance = this;

    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}