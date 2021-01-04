using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptPuntuacion : MonoBehaviour
{
    Puntuacion1 puntuacion;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;

    void Start()
    {
        puntuacion=FindObjectOfType<Puntuacion1>();
    }

    void Update()
    {
        text1.text=puntuacion.PuntuacionJugador1 +" pts";
    }
}
