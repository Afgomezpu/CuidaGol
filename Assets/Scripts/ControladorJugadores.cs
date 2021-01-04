using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugadores : MonoBehaviour
{
    private int jugadores;
    
    
       void Awake(){
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NumeroJugadores(int numero){

        jugadores=numero;
    }

        public int Jugadores   // property
  {
    get { return jugadores; }
    set { jugadores = value; }
  }



}
