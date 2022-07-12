using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

[CreateAssetMenu(fileName = "QuestsData", menuName = "QuestSO")]
public class QuestsSO : ScriptableObject
{

    public QuestTypes questType;
    public string Title;
    public string Description;
    public int GoldReward;
    public bool IsActive;
    public int AvailableAtLevel;
    public int acheiveCounter;
    public int GoalCount;


}
