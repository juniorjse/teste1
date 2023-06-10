using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grafico2 : MonoBehaviour
{
    [SerializeField] private Sprite CirculoSprite;
    private RectTransform graficoConteiner;

    private void Awake()
    {
        graficoConteiner = transform.Find("graficoConteiner").GetComponent<RectTransform>();

        List<int> valorLista= new List<int>() {5, 3, 200, 40};
        MostraGrafico(valorLista);
    }

    private void CriarCirculo(Vector2 anchoredPosition)
    {
        GameObject gameObject= new GameObject("circulo", typeof(Image));
        gameObject.transform.SetParent(graficoConteiner, false);
        gameObject.GetComponent<Image>().sprite= CirculoSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition= anchoredPosition;
        rectTransform.sizeDelta= new Vector2(11, 11);
        rectTransform.anchorMin= new Vector2(0, 0);
        rectTransform.anchorMax= new Vector2(0, 0);
    
    }

    private void MostraGrafico(List<int> valorLista)
    {
        float graficoHeight= graficoConteiner.sizeDelta.y;
        float yMaximum= 100f;
        float xSize= 50f;
        
        for (int i=0; i< valorLista.Count; i++)
        {
            float xPosition= i * xSize;
            float yPosition= (valorLista[i]/yMaximum) * graficoHeight;
            CriarCirculo(new Vector2(xPosition, yPosition));
            /*if (ultimoCirculoGameObject!= null)
            {
                CreateDotConnection(ultimoCirculoGameObject.GetComponent<RectTransform>().anchoredPosition, circuloGameObject.GetComponent<RectTransform>().achoredPosition);
            }
            ultimoCirculoGameObject=circuloGameObject;
        }*/
        
    }

    /*private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject gameObject= new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graficoConteiner, false);
        rectTransform.anchoredPosition= anchoredPosition;
        rectTransform.sizeDelta= new Vector2(0, 0);
        rectTransform.anchorMin= new Vector2(0, 0);
        rectTransform.anchorMax= new Vector2(100, 3f);
        rectTransform.anchoredPosition= dotPositionA;*/
    }
}
