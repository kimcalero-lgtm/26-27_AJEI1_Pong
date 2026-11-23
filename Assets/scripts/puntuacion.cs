using UnityEngine;
using TMPro; 
public class puntuacion : MonoBehaviour
{
    public int puntuacionA;
    public int puntuacionB;

    public TMP_Text puntuacionAtext;
    public TMP_Text puntuacionBtext;

    //int: numero entero
    //float: numero decimal
    //bool: verdadero/falso
    //string: texto o cadena de caracteres
    //Vector3: 3 numeros decimales

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionAtext.text = puntuacionA.ToString();
        puntuacionBtext.text = puntuacionB.ToString();

        if (puntuacionA > 10)
        {
            Debug.Log("El jugador A ha ganado.");
        }
        if (puntuacionB > 10)
        {
            Debug.Log("El jugador B ha ganado.");
        }
    }
}
