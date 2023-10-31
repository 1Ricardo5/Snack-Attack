using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public int scoreToAdd;

    private void OnTriggerEnter(Collider other)
    {
  
        if(other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            pc.score += scoreToAdd;
            Debug.Log(pc.score);
            Destroy(gameObject);
        }else
        {
            Destroy(gameObject);
        }
        
    }  
}   

