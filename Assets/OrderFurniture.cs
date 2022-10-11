using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderFurniture : MonoBehaviour
{
    public static int price;

    public void SendPrice(int price)
    {
        CartZone.price1.Add(price);
    }

}
