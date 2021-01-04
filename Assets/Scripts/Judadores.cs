using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judadores : MonoBehaviour
{
    AdministradorJugadores NumeroJugadores;
    private string nombreJugador;
    
    void Start()
    {
        NumeroJugadores=FindObjectOfType<AdministradorJugadores>();
        NumeroJugadores.textJugador(1);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ombreJugador(string nombre){

        NumeroJugadores.NombreJugador=nombre;
        NumeroJugadores.aceptar.SetActive(true);
        
    }

    public void seleccionarJugador(){
       if(NumeroJugadores.ListaJugadores.Count<NumeroJugadores.Jugadores){
       NumeroJugadores.ingresarJugadores(NumeroJugadores.NombreJugador);
            if(NumeroJugadores.ListaJugadores.Count<NumeroJugadores.Jugadores){
                NumeroJugadores.textJugador(NumeroJugadores.ListaJugadores.Count+1);
            }
            if(NumeroJugadores.ListaJugadores.Count==NumeroJugadores.Jugadores){
                NumeroJugadores.aceptar.SetActive(false);
                NumeroJugadores.siguiente.SetActive(true);     
            }
       }
       else {
           print("ya selecciono los " + NumeroJugadores.Jugadores +" jugadores");
       }

    }

         public string  NombreJugador  // property
  {
    get { return nombreJugador; }
    set { nombreJugador = value; }
  }
}
