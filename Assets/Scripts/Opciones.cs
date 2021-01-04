using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opciones : MonoBehaviour
{
    private string nombrebloque;
    private string dificultad;

      void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {   
      

    }

    public void Bloque(string bloque){

        nombrebloque=bloque;
    }

     public void Gradodificultad(string grado){

        dificultad=grado;
    }

      public string NombreBloque   // property
  {
    get { return nombrebloque; }
    set { nombrebloque = value; }
  }

     public string Dificultad   // property
  {
    get { return dificultad; }
    set { dificultad = value; }
  }
    void Update()
    {
    
    }
}
