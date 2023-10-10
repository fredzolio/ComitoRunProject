using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    //public AudioSource coinFX;
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashSFX;
    public GameObject mainCamera;
    public GameObject lostGameScreen;
    public GameObject uICoinAndDis;
    static public bool gameOver = false;
    public GameObject levelControl;
    void OnTriggerEnter(Collider other){
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        PlayerMove.canMove = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashSFX.Play();
        gameOver = true;
        mainCamera.GetComponent<Animator>().enabled = true;
        lostGameScreen.SetActive(true);
        uICoinAndDis.SetActive(false);
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
