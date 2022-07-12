using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ACharacter
{
    public override void OnAttack(ACharacter Opponent)
    {
        int randomDamage = Random.Range(1, _strength);
        Opponent.TakeDamage(randomDamage);

    }

    public override void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
