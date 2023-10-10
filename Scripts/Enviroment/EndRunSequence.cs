using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence(){
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(0);
    }

}
