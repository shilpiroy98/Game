using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{
    public GameObject bottom;
    public GameObject top;
    public GameObject slider;
    public GameObject currentScore;
    int score;
    private Slider name;

    // Start is called before the first frame update
    void Start()
    {
        name = slider.GetComponent<Slider>();
        name.value = 0;
        score = 0;
        StartCoroutine(Inc());
    }

    private IEnumerator Inc()
    {
        while(true)
        {
            top.GetComponent<AIPlayButton>().Play();
            while (name != null && name.value != 1)
            {
                name.value += 0.1f;
                yield return new WaitForSeconds(0.4f);
            }
            if (name == null)
            {
                Debug.LogError("hoo");
            }
            Check();
            if(currentScore.GetComponentInChildren<TextMeshProUGUI>() != null)
            currentScore.GetComponentInChildren<TextMeshProUGUI>().text = score.ToString();
            name.value = 0;
            bottom.GetComponent<PlayerClick>().ResetFlags();
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    void Check()
    {

        string currentFlag = bottom.GetComponent<PlayerClick>().GetCurrentFlag();
        if(currentFlag == "")
        {
            EndGame();
        }
        else
        {

            string computerFlag = top.GetComponent<AIPlayButton>().GetCurrentSelection();
            if (computerFlag == currentFlag || computerFlag == "") return;
            if(computerFlag == "Rock")
            {
                if(currentFlag == "Spock" || currentFlag == "Paper")
                {
                    score++;
                    return;
                }

            }
            else if(computerFlag == "Spock")
            {
                if(currentFlag == "Lizard" || currentFlag == "Paper")
                {
                    score++;
                    return;
                }
            }
            else if(computerFlag == "Paper")
            {
                if (currentFlag == "Scissor" || currentFlag == "Lizard")
                {
                    score++;
                    return;
                }
            }
            else if(computerFlag == "Lizard")
            {
                if(currentFlag == "Scissor" || currentFlag == "Rock")
                {
                    score++;
                    return;
                }

            }
            else
            {
                if (currentFlag == "Spock" || currentFlag == "Rock")
                {
                    score++;
                    return;
                }
            }
            EndGame();
           
        }
    }


    void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    
}
