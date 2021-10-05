using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMage : Enemy
{
    private float _skeletonMageMaxHealth = 120f;
    private float _randomNumber;

    private void Start()
    {
        SetHealth(_skeletonMageMaxHealth);
    }

    private void Update()
    {
        if (_health <= 0)
        {
            _randomNumber = Random.Range(1, 5);
            StaticMethods.SetPlayerLevel(StaticMethods.GetPlayerLevel() + _randomNumber);
            GameManager.CurrentXP += _randomNumber;
            StaticMethods.SetMoney(StaticMethods.GetMoney() + Random.Range(5, 12));
        }
        HealthChecker();
        GameManager.StaticEnemyHealthbar.fillAmount = _health / _maxHealth;
    }
}
