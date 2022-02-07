using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    private string _current;
    private GameObject timer;
    

    public void ResetFlags()
    {
        _current = "";
    }
    // Start is called before the first frame update
    public void Rock()
    {
        _current = "Rock";
    }

    public string GetCurrentFlag()
    {
        return _current;
    }

    public void Paper()
    {
        _current = "Paper";
    }


    public void Scissor()
    {
        _current = "Scissor";
    }

    public void Spock()
    {
        _current = "Spock";
    }

    public void Lizard()
    {
        _current = "Lizard";
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
