using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class SuchAGoodBoy : MonoBehaviour
{
    Animator anim;

    public NPCConversation convo;
   
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {}

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            anim.SetTrigger("friendly");
            ConversationManager.Instance.StartConversation(convo);
        }
    }
    
}
