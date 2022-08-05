using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestLogic : MonoBehaviour
{
    public TextMeshProUGUI questName;
    public TextMeshProUGUI questObjective;
    public TextMeshProUGUI questObjectiveCnt;
    
    void Start()
    {}
     void Update()
    {}

    public void SetQuestName(string qName){
        questName.text = qName;
    }
    public void SetQuestObjective(string qObjective){
        questObjective.text = qObjective;
    }
    public void SetObjectiveCnt(string qObjectiveCnt){
        questObjectiveCnt.text = qObjectiveCnt;
    }
}
