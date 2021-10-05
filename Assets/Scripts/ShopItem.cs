using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public GameObject Shop;
    public Text Title;
    public Text Description;
    public Text Cost;

    public string TitleContent;
    public string DescriptionContent;
    public string CostContent;

    public int ImprovementLevel;

    private void Start()
    {
        Title.text = ("Title: " + TitleContent);
        Description.text = ("Description: " + DescriptionContent);
        Cost.text = ("Cost: " + CostContent);

        ImprovementLevel = StaticMethods.GetDamageImprovementLevel();
    }

    public void OnClick()
    {
        Shop.GetComponent<Shop>().ShowConfirmationOfPurchase(this.gameObject);
    }
}
