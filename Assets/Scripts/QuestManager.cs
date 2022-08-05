using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject questTrackerPanel;
    public GameObject questPrefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void LocateLake(){
        questPrefab.GetComponent<QuestLogic>().SetQuestName("Locate the Lake");
        questPrefab.GetComponent<QuestLogic>().SetQuestObjective("Find the lake and see if your friends are hiding out there.");
        questPrefab.GetComponent<QuestLogic>().SetObjectiveCnt("Not Found");

        GameObject newQ = Instantiate(questPrefab, questTrackerPanel.transform, false);
        newQ.transform.SetParent(questTrackerPanel.transform);
    }
    public void LocateTrain(){
        questPrefab.GetComponent<QuestLogic>().SetQuestName("Locate the Train");
        questPrefab.GetComponent<QuestLogic>().SetQuestObjective("Find the abandoned train in the woods and see if your friends are hiding out there.");
        questPrefab.GetComponent<QuestLogic>().SetObjectiveCnt("Not Found");

        GameObject newQ = Instantiate(questPrefab, questTrackerPanel.transform, false);
        newQ.transform.SetParent(questTrackerPanel.transform);
    }
    public void LocatePark(){
         questPrefab.GetComponent<QuestLogic>().SetQuestName("Locate the Park");
         questPrefab.GetComponent<QuestLogic>().SetQuestObjective("Find the kids park and see if your friends are hiding out there.");
        questPrefab.GetComponent<QuestLogic>().SetObjectiveCnt("Not Found");

        GameObject newQ = Instantiate(questPrefab, questTrackerPanel.transform, false);
        newQ.transform.SetParent(questTrackerPanel.transform);
    }
    public void LocateWoods(){
       questPrefab.GetComponent<QuestLogic>().SetQuestName("Locate the Woods");
       questPrefab.GetComponent<QuestLogic>().SetQuestObjective("Look through the woods and see if your friends are hiding out there.");
        questPrefab.GetComponent<QuestLogic>().SetObjectiveCnt("Not Found");

        GameObject newQ = Instantiate(questPrefab, questTrackerPanel.transform, false);
        newQ.transform.SetParent(questTrackerPanel.transform);
    }
}
