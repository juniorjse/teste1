using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassaVal : MonoBehaviour
{
    public Text glicemiaText;
    public Text dataText;
    public Text horaText;
    public Text valorFloatText;

    private void Start()
    {
        string glicemia = PlayerPrefs.GetString("Glicemia");
        string data = PlayerPrefs.GetString("Data");
        string hora = PlayerPrefs.GetString("Hora");

        float valorFloat;
        float.TryParse(glicemia, out valorFloat);

        glicemiaText.text = glicemia != null ? glicemia : "";
        dataText.text = data != null ? data : "";
        horaText.text = hora != null ? hora : "";
        valorFloatText.text = valorFloat.ToString();
    }
}
