using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section;
    public int zPos = 60;
    public bool creatingSection = false;
    public int secNum;
    public static float delayToGenerateNewSection = 4;

    void Update(){
        if (creatingSection == false){
            creatingSection = true;
            StartCoroutine(GenerateSection());

        }
        //delayToGenerateNewSection = delayToGenerateNewSection - LevelDistance.increaseSpeedValue;
    }

    IEnumerator GenerateSection(){
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3((float)-4.326632, (float)1.117131, zPos), Quaternion.identity);
        zPos += 60;
        yield return new WaitForSeconds(delayToGenerateNewSection);
        creatingSection = false;
    }
}
