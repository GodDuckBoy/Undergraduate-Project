using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class CartZone : MonoBehaviour
{

    public GameObject g; //g at the Furniture_List_Zone GameObject
    public static int removeNumber;

    [SerializeField] public static List<string> keepName = new List<string>();
    [SerializeField] public static List<string> keepPrice = new List<string>();
    [SerializeField] public static List<Sprite> keepPicture = new List<Sprite>();

    public int total = 0;
    public static int price;
    public Text priceTotal;
    [SerializeField] public static List<int> price1 = new List<int>();

    void Start ()
	{
		GameObject buttonTemplate = transform.GetChild (0).gameObject;

        for (int i = 0; i < keepName.Count; i++) 
        {
			g = Instantiate (buttonTemplate, transform);
			g.transform.GetChild (0).GetComponent <Image> ().sprite = keepPicture[i];
			g.transform.GetChild (1).GetComponent <Text> ().text = keepName[i].ToString();
			g.transform.GetChild (2).GetComponent <Text> ().text = keepPrice[i].ToString();
        }

        // Delete templete that more than N
        Destroy (buttonTemplate);

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

    public void setCoins1()
    {
        if (price1.Count > 0)
        {
            for (int i = 0; i < price1.Count; i++)
            {
                setCoins(price1[i]);
            }
        }
        else if (price1.Count == 0)
        {
            priceTotal.text = "ß 0";
        }
    }

    public void DeleteFurnitre()
    {
        for (int i = 0; i < keepName.Count; i++)
        {
            //Cant destroy duplicate Furniture
           if (g.transform.GetChild(1).GetComponent<Text>().text == keepName[i].ToString())
           {
                Destroy(g);
                CartZone.keepName.Remove(CartZone.keepName[i]);
                CartZone.keepPrice.Remove(CartZone.keepPrice[i]);
                CartZone.keepPicture.Remove(CartZone.keepPicture[i]);
                CartZone.price1.Remove(CartZone.price1[i]);
                setCoins1();
            }
        }
    }
}
