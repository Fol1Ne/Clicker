using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public System.Action DeadEvent;
    public GameObject EnemySpawner;

    protected float _maxHealth = 100f;
    protected float _health = 100f;

    private void Update()
    {
        HealthChecker();
    }

    public void SetEnemySpawner(GameObject enemySpawner)
    {
        EnemySpawner = enemySpawner;
    }

    public void SetHealth(float maxHealth)
    {
        _maxHealth = maxHealth;
        _health = maxHealth;
    }

    public void HealthChecker()
    {
        if (_health <= 0)
        {
            if (GameManager.CurrentXP >= GameManager.NeededXP)
            {
                StaticMethods.SetPlayerLevelNumber(StaticMethods.GetPlayerLevelNumber() + 1);
                GameManager.NeededXP *= 2;
                GameManager.CurrentXP = StaticMethods.GetPlayerLevel() - GameManager.NeededXP / 2;
            }

            Destroy(this.gameObject);

            EnemySpawner.GetComponent<EnemySpawner>().SpawnEnemy();
        }
    }

    private void OnMouseDown()
    {
        _health -= GameManager.Damage;
        GameManager.StaticEnemyHealthbar.fillAmount = _health / _maxHealth;
    }
}
