using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NovaTela1 : MonoBehaviour
{
    public static string instance1;
    public static string instance2;
    public static string instance3;

    public InputField inputGlicemia;
    public InputField inputData;
    public InputField inputHora;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Aguarde um frame antes de acessar os campos de entrada de texto
        StartCoroutine(StartAfterFrame());
    }

    IEnumerator StartAfterFrame()
    {
        yield return null; // Aguardar um frame

        instance1 = inputGlicemia.text;
        instance2 = inputData.text;
        instance3 = inputHora.text;
    }

    public void MudarCena(string Tela2)
    {
        PlayerPrefs.SetString("Glicemia", inputGlicemia.text);
        PlayerPrefs.SetString("Data", inputData.text);
        PlayerPrefs.SetString("Hora", inputHora.text);
        PlayerPrefs.Save();

        SceneManager.LoadScene(Tela2);
    }

    public void Glicemia(string g)
    {
        instance1 = g;
    }

    public void Data(string d)
    {
        instance2 = d;
    }

    public void Hora(string h)
    {
        instance3 = h;
    }
}
