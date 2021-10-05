using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerLevelNumber;
    public Image PlayerLevel;
    public Image EnemyHealthbar;
    public TextMeshProUGUI Money;
    public GameObject EnemySpawner;
    public GameObject MainScreen;
    public GameObject ShopScreen;
    public GameObject CurrentEnemy;

    public static int Damage;
    public static float NeededXP = 100f;
    public static float CurrentXP;
    public static Image StaticEnemyHealthbar;

    private void Start()
    {
        StaticEnemyHealthbar = EnemyHealthbar;


        PlayerLevelNumber.text = ("LVL: " + StaticMethods.GetPlayerLevelNumber());

        for (int i = 0; i < StaticMethods.GetPlayerLevelNumber(); i++)
        {
            NeededXP *= 2;
        }

        if (StaticMethods.GetPlayerLevelNumber() == 0)
        {
            CurrentXP = StaticMethods.GetPlayerLevel();
        }
        else
        {
            CurrentXP = StaticMethods.GetPlayerLevel() - NeededXP / 2;
        }


        PlayerLevel.fillAmount = CurrentXP / NeededXP;
        Money.text = (StaticMethods.GetMoney() + "$");

        Damage = StaticMethods.GetDamage();

        EnemySpawner.GetComponent<EnemySpawner>().SpawnEnemy();
    }

    private void Update()
    {
        PlayerLevelNumber.text = ("LVL: " + StaticMethods.GetPlayerLevelNumber());
        PlayerLevel.fillAmount = CurrentXP / NeededXP;
        Money.text = (StaticMethods.GetMoney() + "$");
    }

    public void ChangeToShopScreen()
    {
        MainScreen.SetActive(false);
        ShopScreen.SetActive(true);
        Destroy(CurrentEnemy.gameObject);
    }

    public void ChangeToMainScreen()
    {
        ShopScreen.SetActive(false);
        MainScreen.SetActive(true);
        EnemySpawner.GetComponent<EnemySpawner>().SpawnEnemy();
    }
}
