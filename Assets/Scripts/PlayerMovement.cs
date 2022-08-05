using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMoveSpeed = 5.0f;
    public float playerRotateSpeed = 50f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private float gravityValue = -9.81f;
    
    private Animator anim;

    private float jumpHeight = 5.0f;
    private bool groundedPlayer;

    public GameObject inGameMenu;

    public NPCConversation convo;

    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        anim = this.gameObject.GetComponent<Animator>();
        ConversationManager.Instance.StartConversation(convo);
    }

    void Update()
    {
        Vector3 moveDir = transform.TransformDirection(Vector3.forward);

        //move forward
        if(Input.GetAxis("Vertical") > 0){
            controller.Move(moveDir * Time.deltaTime * playerMoveSpeed);
            anim.SetInteger("walk", 1);
            if(Input.GetKeyDown(KeyCode.LeftShift)){
                anim.SetBool("run", true);
                playerMoveSpeed = 15f;
            }
        }
        //move backward
        else if(Input.GetAxis("Vertical") < 0){
            controller.Move(-moveDir * Time.deltaTime * playerMoveSpeed);
            anim.SetInteger("walk", 1);
            if(Input.GetKeyDown(KeyCode.LeftShift)){
                anim.SetBool("run", true);
                playerMoveSpeed = 15f;
            }
        }
        else{
            anim.SetInteger("walk", 0);
            anim.SetBool("run", false);
            playerMoveSpeed = 5f;
        }
        //rotate player
        if(Input.GetAxis("Horizontal") > 0){
            transform.Rotate(Vector3.up * Time.deltaTime * playerRotateSpeed);
        }
        else if(Input.GetAxis("Horizontal") < 0){
            transform.Rotate(-Vector3.up * Time.deltaTime * playerRotateSpeed);
        }

        //jump
        groundedPlayer = controller.isGrounded;
        if(Input.GetButtonDown("Jump") && groundedPlayer){
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            anim.SetTrigger("jump");
        }

        else if(Input.GetKeyDown(KeyCode.Escape)){
            inGameMenu.SetActive(true);
        }

        //gravity affects player
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
