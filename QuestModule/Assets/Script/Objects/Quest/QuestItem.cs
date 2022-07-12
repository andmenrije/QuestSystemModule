using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

public class QuestItem
{
    public QuestTypes questType;
    public string Title;
    public string Description;
    public int GoldReward;
    public bool IsActive;
    public int AvailableAtLevel;
    private QuestItem newQuestItem;

    public QuestItem()
    {
    }

    public QuestItem(QuestItem newQuestItem)
    {
        this.newQuestItem = newQuestItem;
    }

    public static explicit operator QuestItem(QuestsSO v)
    {
        return new QuestItem()
        {
            questType = v.questType,
            AvailableAtLevel = v.AvailableAtLevel,
            Description = v.Description,
            GoldReward = v.GoldReward,
            Title = v.Title,
            IsActive = v.IsActive
        };
    }
}
