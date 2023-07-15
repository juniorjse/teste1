using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grafico20 : MonoBehaviour
{
    [SerializeField] private Sprite CirculoSprite;
    private RectTransform graficoConteiner;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private void Aweke()
    {
        graficoConteiner = transform.Find("graficoConteiner").GetComponent<RectTransform>();

        CriarCirculo(new Vector2(50, 50));
    }

    private void CriarCirculo(Vector2 anchoredPosition)
    {
        GameObject gameObject= new GameObject("circulo", typeof(Image));
        gameObject.transform.SetParent(graficoConteiner, false);
        gameObject.GetComponent<Image>().sprite= CirculoSprite;
        RectTransform reactTransform = gameObject.GetComponent<RectTransform>();
        reactTransform.anchoredPosition= anchoredPosition;
        reactTransform.sizeDelta= new Vector2(11, 11);
        reactTransform.anchorMin= new Vector2(0, 0);
        reactTransform.anchorMax= new Vector2(0, 0);
    }
}
