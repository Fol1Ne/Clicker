using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject GameManager;
    public ParticleSystem EnemyDeathEffect;
    public GameObject[] EnemiesList;

    public void SpawnEnemy()
    {
        EnemyDeathEffect.Play();

        Invoke("SpawnEnemy2", 0.5f);
    }

    public void SpawnEnemy2()
    {
        var enemy = EnemiesList[Random.Range(0, EnemiesList.Length)];
        GameManager.GetComponent<GameManager>().CurrentEnemy = Instantiate(enemy, new Vector3(-0.27f, -1.2f, 0), new Quaternion(0, 0, 0, 0));

        if (enemy.TryGetComponent(out SkeletonMage skeletonMage))
        {
            skeletonMage.SetEnemySpawner(this.gameObject);
        }
        else if (enemy.TryGetComponent(out SkeletonArcher skeletonArcher))
        {
            skeletonArcher.SetEnemySpawner(this.gameObject);
        }
        else if (enemy.TryGetComponent(out SkeletonWarrior skeletonWarrior))
        {
            skeletonWarrior.SetEnemySpawner(this.gameObject);
        }
    }
}
