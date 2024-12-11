using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    
    public TMP_Text scoreText;
   
    void Update() 
    {
        scoreText.text = $"Score: {DisappearOnCollision.Score}";
    }
    
}
