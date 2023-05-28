using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valor : MonoBehaviour
{
    public Text valorGtxt;
    public Text valorDtxt;
    public Text valorHtxt;

    public string valorG;
    public string valorD;
    public string valorH;
    
    
    
    public static valor instance;
    void Start()
    {
        instance= this;
        valorGtxt.text=valorG;
        valorDtxt.text=valorD;
        valorHtxt.text=valorH;
    }
}
