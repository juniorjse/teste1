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
        valorGtxt.text= NovaTela1.instance1;
        valorDtxt.text= NovaTela1.instance2;
        valorHtxt.text= NovaTela1.instance3;
    }

}
