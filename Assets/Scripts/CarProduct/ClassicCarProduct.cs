using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicCarProduct : MonoBehaviour, ICarProduct
{
   public void SetColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }

    public void Drive()
    {
        Debug.Log("Classic car is driving.");
    }
}
