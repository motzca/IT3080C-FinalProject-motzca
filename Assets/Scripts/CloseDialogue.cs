using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CloseDialogue : MonoBehaviour
{
    public NPCConversation conv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDialog(){
        ConversationManager.Instance.EndConversation();
    }
}
