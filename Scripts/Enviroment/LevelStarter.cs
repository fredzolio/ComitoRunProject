using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public GameObject uICoinAndDis;
    public GameObject test;


    void Start(){
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence(){
        CollectableControl.coinCount = 0;
        LevelDistance.disRun = 0;
        LevelDistance.multiplier = 1.00000000001f;
        LevelDistance.increaseSpeedValue = 1;
        uICoinAndDis.SetActive(true);
        test.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        PlayerMove.canMove = true;
        CollectableControl.coinCount = 0;
        LevelDistance.disRun = 0;
        LevelDistance.multiplier = 1.01f;
        LevelDistance.increaseSpeedValue = 1;
    }
}
