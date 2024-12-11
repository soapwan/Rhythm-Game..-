using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisappearOnCollision : MonoBehaviour
{
    public GameObject Note;
    
    public static int Score;
    
    //public TMP_Text ScoreText;
 /*   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(Note);
        }
    }
*/  //
 
    void OnTriggerStay2D(Collider2D other){
        Debug.Log("BAM");    
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other.gameObject);
            
            Score += 50;
        }
    } 
   
     /*   void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(Note);
                
             }
         } */
}