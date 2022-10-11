using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class AddCart : MonoBehaviour
{
    public static void AddName(string name)
    {
        CartZone.keepName.Add(name);
    }

    public static void AddPrice(string price)
    {
        CartZone.keepPrice.Add(price);
    }

    public static void AddPicture(Sprite picture)
    {
        CartZone.keepPicture.Add(picture);
    }
}
