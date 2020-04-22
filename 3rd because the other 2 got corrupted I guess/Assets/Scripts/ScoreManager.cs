using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ScoreManager : MonoBehaviour
{
    public static int score;
    public int winScore;

    public Text winText;
    public Text scoreText;


    private void Awake()
    {
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
        winText.GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0) 
            score = 0;
     

        if(score >= winScore)
        {
            print("Win score reached = " + score);
            winText.GetComponent<Text>().enabled = true;
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log("Relics Collected: " + score);
    }


}
