using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationAR : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject InformationPanel1st;
    [SerializeField] GameObject InformationPanel2nd;

    public void togglePanel()
    {
        if (isOn)
        {
            InformationPanel1st.SetActive(false);
            isOn = false;
        }
        else
        {
            InformationPanel1st.SetActive(true);
            isOn = true;
        }
    }

    public void close1stPopUps()
    {
            InformationPanel1st.SetActive(false);
            isOn = false;
    }

    public void close2ndPopUps()
    {
            InformationPanel2nd.SetActive(false);
            isOn = false;
    }

    public void closePopUps()
    {
            InformationPanel1st.SetActive(false);
            InformationPanel2nd.SetActive(false);
            isOn = false;
    }
}
