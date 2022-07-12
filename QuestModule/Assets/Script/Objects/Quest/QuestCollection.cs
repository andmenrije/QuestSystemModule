using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCollection : MonoBehaviour
{

    [SerializeField] private List<QuestItem> _quests = new List<QuestItem>();

    public List<QuestItem> Quests => _quests;

    public void AddQuest(QuestItem questItem)
    {
        _quests.Add(questItem);
    }

    internal void BuildQuestItemDisplay(GameObject questPrefab, GameObject questsParent)
    {
        foreach(QuestItem qi in _quests)
        {
            GameObject newObject = Instantiate(questPrefab, questsParent.transform);
            IFillable quest = newObject.GetComponent<IFillable>();
            quest.Populate(new QuestItemDTO() { itemDetails = qi });
        }
    }
}
