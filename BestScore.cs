using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BestScore : MonoBehaviour
{


    public Text bestText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
       
        Target target = GameObject.FindObjectOfType<Target>();
        int score = target.GetScore();

        if (score > PlayerPrefs.GetInt("Best"))
            PlayerPrefs.SetInt("Best", score);

        bestText.text = PlayerPrefs.GetInt("Best") + "";

        scoreText.text = score + "";

       
    }
}
