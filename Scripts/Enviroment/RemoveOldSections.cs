using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOldSections : MonoBehaviour
{
    public string parentName;
    public static float delayTimeToDestroyOldSections = 90;

    void Start(){
        parentName = transform.name;
        //delayTimeToDestroyOldSections = delayTimeToDestroyOldSections - LevelDistance.increaseSpeedValue;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone(){
        yield return new WaitForSeconds(delayTimeToDestroyOldSections);
        if(parentName == "Section(Clone)"){
            Destroy(gameObject);
        }
    }
}
