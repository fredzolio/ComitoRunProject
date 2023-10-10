using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    void Update(){

        //Faz o player ir andando para frente infinitamente;
        transform.Translate(Vector3.forward * Time.deltaTime * (moveSpeed + (LevelDistance.increaseSpeedValue * 0.3f)), Space.World);
        if(canMove == true){
            //Anda o player para a esquerda;
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                if(this.gameObject.transform.position.x > LevelBoundary.leftSide){
                    transform.Translate(Vector3.left * Time.deltaTime * (leftRightSpeed + (LevelDistance.increaseSpeedValue * 0.1f)));
                }
            }
            
            //Anda o player para a direita;
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                if(this.gameObject.transform.position.x < LevelBoundary.rightSide){
                    transform.Translate(Vector3.right * Time.deltaTime * (leftRightSpeed + (LevelDistance.increaseSpeedValue * 0.1f)));
                }
            }

            //Pula
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)){
                if(isJumping == false){
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }
        if(isJumping == true){
            if(comingDown == false){
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if(comingDown == true){
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator JumpSequence(){
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Run");
    }
}
