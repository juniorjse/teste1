using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class Grafico2 : MonoBehaviour
{
    [SerializeField] private Sprite CirculoSprite;
    private RectTransform graficoConteiner;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;

    private void Awake()
    {
        graficoConteiner = transform.Find("graficoConteiner").GetComponent<RectTransform>();
        labelTemplateX = graficoConteiner.Find("labelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = graficoConteiner.Find("labelTemplateY").GetComponent<RectTransform>();

        List<int> valorLista= new List<int>() {400, 600, 450, 400, 500};
        MostraGrafico(valorLista);
    }

    private GameObject CriarCirculo(Vector2 anchoredPosition)
    {
        GameObject gameObject= new GameObject("circulo", typeof(Image));
        gameObject.transform.SetParent(graficoConteiner, false);
        gameObject.GetComponent<Image>().sprite= CirculoSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition= anchoredPosition;
        rectTransform.sizeDelta= new Vector2(11, 11);
        rectTransform.anchorMin= new Vector2(0, 0);
        rectTransform.anchorMax= new Vector2(0, 0);
        return gameObject;
    }

    private void MostraGrafico(List<int> valorLista)
    {
        float graficoHeight= graficoConteiner.sizeDelta.y;
        float yMaximum= 100f;
        float xSize= 50f;
        
        GameObject ultimoCirculoGameObject = null;
        for (int i=0; i< valorLista.Count; i++)
        {
            float xPosition= xSize + i * xSize;
            float yPosition= (valorLista[i]/yMaximum) * graficoHeight;
            GameObject circuloGameObject= CriarCirculo(new Vector2(xPosition, yPosition));
            if (ultimoCirculoGameObject!= null)
            {
                CreateDotConnection(ultimoCirculoGameObject.GetComponent<RectTransform>().anchoredPosition, circuloGameObject.GetComponent<RectTransform>().anchoredPosition);
            }
            ultimoCirculoGameObject=circuloGameObject;
        }
        
    }

    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject gameObject= new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graficoConteiner, false);
        gameObject.GetComponent<Image>().color= new Color(1,1,1, .5f);
        RectTransform rectTransform= gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA,dotPositionB);
        rectTransform.sizeDelta= new Vector2(distance, 3f);
        rectTransform.anchorMin= new Vector2(0, 0);
        rectTransform.anchorMax= new Vector2(0, 0);
        rectTransform.anchoredPosition= dotPositionA + dir * distance * .5f;
        rectTransform.localEulerAngles =  new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }
}
