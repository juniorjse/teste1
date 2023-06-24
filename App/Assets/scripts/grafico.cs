using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grafico : MonoBehaviour
{
    public Transform pointPrefab;
    public int resolucao= 10;
    public float escala= 1f;

    void start()
    {
        awake();
    }
    void awake()
    {
        float step= 2f/resolucao;
        Vector3 escalaVetor= Vector3.one * escala;
        for (int i =0; i<=resolucao;i++)
        {
            Transform  point =Instantiate(pointPrefab);
            point.localScale= escalaVetor;
            point.SetParent(transform);
            point.localPosition= new
            Vector3((i*step - 1f)* escala, 0f, 0f);
        }
    }
}
