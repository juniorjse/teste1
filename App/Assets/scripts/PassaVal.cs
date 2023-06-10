using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassaVal : MonoBehaviour
{
    public Text valorGtxt;
    public Text valorDtxt;
    public Text valorHtxt;


    void Start()
    {
        valorGtxt.text= PlayerPrefs.GetString("Glicemia");
        valorDtxt.text= PlayerPrefs.GetString("Data");
        valorHtxt.text= PlayerPrefs.GetString("Hora");
    }

}
