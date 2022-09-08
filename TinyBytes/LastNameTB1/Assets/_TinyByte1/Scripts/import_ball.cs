using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class import_ball : MonoBehaviour
{
    public GameObject ball;

    public void displayBall(){

        if(ball != null){
        bool isActive = ball.activeSelf;
        ball.SetActive(!isActive);
        }
        
    }
}
