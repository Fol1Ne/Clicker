using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMethods : MonoBehaviour
{
    public static void SetPlayerLevelNumber(int LevelNumber)
    {
        PlayerPrefs.SetInt("PlayerLevelNumber", LevelNumber);
    }

    public static int GetPlayerLevelNumber()
    {
        return PlayerPrefs.GetInt("PlayerLevelNumber", 0);
    }

    public static void SetPlayerLevel(float CurrentLevelPrecentage)
    {
        PlayerPrefs.SetFloat("PlayerLevel", CurrentLevelPrecentage);
    }

    public static float GetPlayerLevel()
    {
        return PlayerPrefs.GetFloat("PlayerLevel", 0f);
    }

    public static void SetMoney(int Money)
    {
        PlayerPrefs.SetInt("Money", Money);
    }

    public static int GetMoney()
    {
        return PlayerPrefs.GetInt("Money", 0);
    }

    public static void SetDamage(int Damage)
    {
        PlayerPrefs.SetInt("Damage", Damage);
    }

    public static int GetDamage()
    {
        return PlayerPrefs.GetInt("Damage", 10);
    }

    public static void SetDamageImprovementLevel(int ImprovementLevel)
    {
        PlayerPrefs.SetInt("ImprovementLevel", ImprovementLevel);
    }

    public static int GetDamageImprovementLevel()
    {
        return PlayerPrefs.GetInt("ImprovementLevel", 0);
    }
}
