using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    [SerializeField] private GameObject _questsParent;
    [SerializeField] private GameObject _questPrefab;
    [SerializeField] private List<QuestsSO> _questItems;

    private QuestCollection _questCollectionComponent;

    private void Awake()
    {
        _questCollectionComponent = _questsParent.GetComponent<QuestCollection>();
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (QuestsSO newQuestItem in _questItems)
        {
            _questCollectionComponent.AddQuest((QuestItem)newQuestItem);
        }

        _questCollectionComponent.BuildQuestItemDisplay(_questPrefab, _questsParent);
    }

}
