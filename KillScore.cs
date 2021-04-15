using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScore : MonoBehaviour
{
    public Text scoreText;
    int score;



    // Start is called before the first frame update
    void Start()
    {
        scoreText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddPoints()
    {
        if (!scoreText.gameObject.activeSelf)
            scoreText.gameObject.SetActive(true);

        score++;
        scoreText.text = "" + score;
    }

    public int GetScore()
    {
        return score;
    }

}
