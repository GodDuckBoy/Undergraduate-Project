using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    [SerializeField] GameObject furniture;

    bool rotateLeft = false;
    bool rotateRight = false;
    float rotatespeed = 20f;

    public void RotateLeft()
    {
        if (rotateLeft == false)
        {
            rotateLeft = true;
        }
        else 
        {
            rotateLeft = false;
        }
    }

    public void RotateRight()
    {
        if (rotateRight == false)
        {
            rotateRight = true;
        }
        else 
        {
            rotateRight = false;
        }
    }

    public void Update()
    {
        //Going Left
        if (rotateLeft == true)
        {
            furniture.transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);
        }

        //Going Right
        if (rotateRight == true)
        {
            furniture.transform.Rotate(Vector3.up, -rotatespeed * Time.deltaTime);
        }
    }

}
