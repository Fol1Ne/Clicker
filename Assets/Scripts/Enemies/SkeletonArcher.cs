using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonArcher : Enemy
{
    private float _skeletonArcherMaxHealth = 180f;
    private float _randomNumber;

    private void Start()
    {
        SetHealth(_skeletonArcherMaxHealth);
    }

    private void Update()
    {
        if (_health <= 0)
        {
            _randomNumber = Random.Range(3, 8);
            StaticMethods.SetPlayerLevel(StaticMethods.GetPlayerLevel() + _randomNumber);
            GameManager.CurrentXP += _randomNumber;
            StaticMethods.SetMoney(StaticMethods.GetMoney() + Random.Range(8, 15));
        }
        HealthChecker();
        GameManager.StaticEnemyHealthbar.fillAmount = _health / _maxHealth;
    }
}
