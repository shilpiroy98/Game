using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIPlayButton : MonoBehaviour
{
    string _currentSelection;
    string[] options = new string[] { "Rock", "Paper", "Scissor", "Spock", "Lizard" };
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Play()
    {
        int idx = Random.Range(0, 4);
        _currentSelection = options[idx];
        this.GetComponentInChildren<Text>().text = options[idx];
    }

    public string GetCurrentSelection()
    {
        return _currentSelection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
