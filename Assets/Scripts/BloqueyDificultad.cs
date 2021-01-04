using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueyDificultad : MonoBehaviour
{

     public Opciones opcion1;
     private string bloque;
     private string dificultad;

   
     void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bloque=opcion1.NombreBloque;
        bloque=opcion1.Dificultad;
    }

        public string Bloque   // property
  {
    get { return bloque; }
    set { bloque = value; }
  }

      public string Dificultad   // property
  {
    get { return dificultad; }
    set { dificultad = value; }
  }
}
