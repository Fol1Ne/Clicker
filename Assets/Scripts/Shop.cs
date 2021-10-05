using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public GameObject ConfirmationOfPurchase;

    private GameObject SelectedItem;

    public void ShowConfirmationOfPurchase(GameObject SelectedItem)
    {
        this.SelectedItem = SelectedItem;
        ConfirmationOfPurchase.SetActive(true);
    }

    public void MakeAPurchase()
    {
        SelectedItem.GetComponent<ShopItem>().ImprovementLevel++;
        StaticMethods.GetDamageImprovementLevel();
        StaticMethods.SetDamage(StaticMethods.GetDamage() + (SelectedItem.GetComponent<ShopItem>().ImprovementLevel * 5));
        ConfirmationOfPurchase.SetActive(false);
    }

    public void DoNotMakeAPurchase()
    {
        ConfirmationOfPurchase.SetActive(false);
    }
}
