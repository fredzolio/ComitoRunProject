using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelDistance : MonoBehaviour
{
   
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public static float disRun;
    public static float increaseSpeedValue = 1;
    public static float multiplier = 1.00000000001f;
    public int maxSpeed = 15;
    public bool addingDis = false;
    public float disDelay = 0.35f;
    void Update()
    {
        if(addingDis == false && PlayerMove.canMove == true){
            addingDis = true;
            StartCoroutine(AddingDis());
        } else if(ObstacleCollision.gameOver == true){
            //disDisplay.SetActive(false);
        }
    }

    IEnumerator AddingDis(){
        
        disRun += 1 + increaseSpeedValue;
        disDisplay.GetComponent<Text>().text = "" + Math.Round(disRun, 1);
        disEndDisplay.GetComponent<Text>().text = "" + Math.Round(disRun, 1);
        yield return new WaitForSeconds(disDelay*(multiplier));
        if(increaseSpeedValue <= maxSpeed){
            increaseSpeedValue = increaseSpeedValue*multiplier;
        }
        addingDis = false;
    }
}
