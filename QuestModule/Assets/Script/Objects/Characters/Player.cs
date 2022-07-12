using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ACharacter
{
    public override void OnAttack(ACharacter Opponent)
    {
        int randomDamage = Random.Range(1, _strength);
        Opponent.TakeDamage(randomDamage);
        
        if(Opponent.IsDead)
        {
            _experience += Opponent.KillReward;
        }
    }

    public override void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
