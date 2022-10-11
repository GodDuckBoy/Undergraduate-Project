using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAnimation : MonoBehaviour
{
    public Animator kok;
    public GameObject checkout;
    public float sec;

    public void TrigAnimOff()
    {
        StartCoroutine(LateDeactivated(sec));
    }

    IEnumerator LateDeactivated(float seconds)
    {
        kok.SetTrigger("PopOut");

        yield return new WaitForSeconds(seconds);

        checkout.SetActive(false);
    }
    public void TrigAnimOn()
    {
        checkout.SetActive(true);
        kok.SetTrigger("PopIn");
        
    }

    public void TrigAnimOnOff()
    {
        checkout.SetActive(true);
        kok.SetTrigger("PopIn");
        StartCoroutine(LateDeactivated(sec));
    }
}
