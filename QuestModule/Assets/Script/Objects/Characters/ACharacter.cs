using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ACharacter : MonoBehaviour
{

    [SerializeField] internal int _gold;
    [SerializeField] internal int _strength;
    [SerializeField] internal int _experience;
    [SerializeField] internal int _health;
    [SerializeField] internal int _killReward;

    public bool IsDead => _health > 0;
    public int KillReward => KillReward;

    public virtual void Initialize(int initGold, int initStrength, int initExperience, int initHealth, int initKillReward)
    {
        _gold = initGold;
        _strength = initStrength;
        _experience = initExperience;
        _health = initHealth;
        _killReward = initKillReward;
    }

    public abstract void OnAttack(ACharacter Opponent);

    public abstract void TakeDamage(int damage);
}
