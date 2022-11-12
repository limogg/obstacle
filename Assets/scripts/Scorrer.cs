using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorrer : MonoBehaviour
{
    int Score = 0;
 private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            Debug.Log("Uderzyłeś "+ Score +" Razy"); 
            Score ++;
        }
    }
}
