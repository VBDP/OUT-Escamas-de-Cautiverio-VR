using TMPro;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public int puntuacionFinal = 0;
    public TextMeshProUGUI puntuacionText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuacionFinal = PlayerPrefs.GetInt("PuntuacionFinal", 0);
        puntuacionText.text = puntuacionFinal.ToString() + " Puntos";
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
