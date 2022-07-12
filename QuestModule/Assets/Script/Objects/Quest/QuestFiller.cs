using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestFiller : MonoBehaviour, IFillable
{
    [SerializeField] private TextMeshProUGUI _TextFieldComp;
    [SerializeField] private TextMeshProUGUI _DescriptionFieldComp;
    [SerializeField] private TextMeshProUGUI _RewardFieldComp;
    [SerializeField] private TextMeshProUGUI _ProgressFieldComp;
    public void Populate(IDTO properties)
    {
        QuestItem questItem = (properties as QuestItemDTO).itemDetails;

        _TextFieldComp.text = questItem.Title;
        _DescriptionFieldComp.text = questItem.Description;
        _RewardFieldComp.text = " Reward: " + questItem.GoldReward.ToString();
        _ProgressFieldComp.text = string.Empty;
    }

}
