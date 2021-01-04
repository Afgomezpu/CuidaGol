using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    ControladorJugadores jugadores;
    void Start()
    {
        jugadores = GameObject.Find("ControladorJugadores").GetComponent<ControladorJugadores>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enviar(int n){
        jugadores.NumeroJugadores(n);
        print(n);
    }

}
