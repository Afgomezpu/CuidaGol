using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respuestas : MonoBehaviour
{
   public bool correcta=false;
    public Administradortest administradortest;
   public void pregunta(){
        if(correcta)
        {   administradortest.Respuesta=true;
            Debug.Log("Respuesta correcta");
            administradortest.EliminarPregunta();
            
        }
        else
        {   administradortest.Respuesta=false;
            administradortest.EliminarPregunta();
            Debug.Log("Respuesta incorrecta");
            
        }
   }
 
}
