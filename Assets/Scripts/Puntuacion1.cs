using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion1 : MonoBehaviour
{
    private int puntuacionJugador1;
    private int puntuacionJugador2;
    private int puntuacionJugador3;

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

       public int  PuntuacionJugador1  // property
     {
    get { return puntuacionJugador1; }
    set { puntuacionJugador1 = value; }
    }

       public int  PuntuacionJugador2  // property
     {
    get { return puntuacionJugador2; }
    set { puntuacionJugador2 = value; }
    }

       public int  PuntuacionJugador3  // property
     {
    get { return puntuacionJugador3; }
    set { puntuacionJugador3 = value; }
    }
}
