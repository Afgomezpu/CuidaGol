using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptByd : MonoBehaviour
{
      Opciones bloqueydificultad;
    void Start()
    {
        bloqueydificultad = GameObject.Find("BloqueyDificultad").GetComponent<Opciones>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void enviarBloque(string bloque){
        bloqueydificultad.Bloque(bloque);
        print(bloque);
    }

      public void enviarDificultad(string grado){
        bloqueydificultad.Gradodificultad(grado);
        print(grado);
    }  
    
}
