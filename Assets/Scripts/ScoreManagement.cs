using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagement : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LooseALife()
    {
        lives -= 1;
        Debug.Log("vies restantes : " + lives);
        if(lives <= 0)
        {
            Debug.Log("Game Over, vous avez perdu toutes vos vies");
            lives = 0;
        }
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Votre score : " + score);
    }
}
