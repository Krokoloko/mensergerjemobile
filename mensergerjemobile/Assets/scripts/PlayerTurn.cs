using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour {
    [SerializeField]
    private int _players = 2;
    public string currentPlayer = "red";
    private string _nextPlayer;
    private BeardCone _cone;
	// Use this for initialization
	void Start () {
        _cone = GetComponent<BeardCone>();
	}
	
	// Update is called once per frame
	void Update () {
        _cone.currentColour = currentPlayer;

        switch (currentPlayer)
        {
            case ("red"):
                if (_players == 2)
                {
                    _nextPlayer = "blue";
                }
                else
                {
                    _nextPlayer = "yellow";
                }
                break;
            case ("yellow"):
                _nextPlayer = "blue";
                break;
            case ("blue"):
                if (_players == 4)
                {
                    _nextPlayer = "green";
                }
                else
                {
                    _nextPlayer = "red";
                }
                break;
            case ("green"):
                _nextPlayer = "red";
                break;
            default:
                _nextPlayer = "blue";
                break;
        }
	}

    public void NextPlayer()
    {
        currentPlayer = _nextPlayer;
    }
}
