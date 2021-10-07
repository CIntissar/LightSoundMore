using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundTest;
   
    private void OnMouseDown() 
    {
        soundTest.Play(0);    
    }

    // void Update()
    // {
    //     if(Input.GetKeyDown("space"))
    //     {
    //         soundTest.Play(0); // 0 pour zéro delay
    //     }
    //     else if(Input.GetKeyDown("enter"))
    //     {
    //         soundTest.UnPause();
    //     }
    // }
}
