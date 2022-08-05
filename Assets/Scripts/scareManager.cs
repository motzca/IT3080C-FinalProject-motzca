using System.Collections;
using System.Collections.Generic;
using TMPro;
using DialogueEditor;
using UnityEngine;
using UnityEngine.UI;

public class scareManager : MonoBehaviour
{
    public TextMeshProUGUI scareText;

    private AudioSource audioSrc;

    public NPCConversation convo;
    // Start is called before the first frame update
    void Start()
    {
        scareText.text = "25";
        audioSrc = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {}
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("SkeletonFound")){
            float scareVal = float.Parse(scareText.text) + other.gameObject.GetComponent<scareScript>().scareValue;
            scareText.text = "" + scareVal;
            Destroy(other.gameObject);
            audioSrc.Play();
            ConversationManager.Instance.StartConversation(convo);
        }
    }
}
