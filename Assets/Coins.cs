using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int total = 0;
    public static int price;
    public Text priceTotal;
    [SerializeField] public static List<int> price1 = new List<int>();
    // Update is called once per frame

    private void Start()
    {
        for (int i = 0; i < price1.Count; i++)
        {
            setCoins(price1[i]);
        }
    }

    public void setCoins(int price)
    {
        total = total + price;
        priceTotal.text = "ß " + total.ToString();
        Debug.Log(total);
    }

    public void setCoins1(int price)
    {
        total = total - price;
        priceTotal.text = "ß " + total.ToString();
        Debug.Log(total);
    }

}
