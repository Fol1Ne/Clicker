using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonWarrior : Enemy
{
    private float _skeletonWarriorMaxHealth = 250f;
    private float _randomNumber;

    private void Start()
    {
        SetHealth(_skeletonWarriorMaxHealth);
    }

    private void Update()
    {
        if (_health <= 0)
        {
            _randomNumber = Random.Range(5, 10);
            StaticMethods.SetPlayerLevel(StaticMethods.GetPlayerLevel() + _randomNumber);
            GameManager.CurrentXP += _randomNumber;
            StaticMethods.SetMoney(StaticMethods.GetMoney() + Random.Range(10, 20));
        }
        HealthChecker();
        GameManager.StaticEnemyHealthbar.fillAmount = _health / _maxHealth;
    }
}
