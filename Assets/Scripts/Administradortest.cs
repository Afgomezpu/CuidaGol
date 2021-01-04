using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Administradortest : MonoBehaviour
{
    private bool siguienteCobro;
    private bool respuesta;
    public GameObject botonSeguir;
    bool penalbool;
    private bool veintiunabool;
    Puntuacion1 puntuacion;
    Opciones Bloques;
    AdministradorJugadores NumeroJugadores;
    List<preguntas> adm;
    ListaPreguntas listaPreguntas1; 
    int Preguntactual;
    public GameObject kinect;
    public GameObject Ballpenalty;
    public GameObject BallVeintiuna;
    public TextMeshProUGUI preguntaTxt;
    public GameObject ContenedorVeintiuna;
    public GameObject textJugador;
    public GameObject panel;
    public GameObject[] options;
    public GameObject back;
    public GameObject front;
    public GameObject[] ListadeJugadores;
    public GameObject obstaculo1;
    public GameObject obstaculo2;
    public GameObject obstaculo3;
    List<string> NombreJugadores;
    int numeroPreguntas;
    private bool siguientePregunta;
    bool balon;
    bool terreno;
    bool player1;
    bool player2;
    bool player3;
    string Jugador1;
    string Jugador2;
    string Jugador3;
    int contador;
    int numeroiteraciones;
    private Vector3 positionInicial;
    Vector3 positionAvatar;
    private Vector3 positionFinal;
       private void Start()
    {   
        SiguienteCobro=false;
        penalbool=true ;
        veintiunabool=false;
        numeroiteraciones=0;
        positionAvatar.x=PositionInicial.x-1.5f;
        positionAvatar.y=PositionInicial.y;
        positionAvatar.z=PositionInicial.z;
        positionFinal=ListadeJugadores[0].transform.position;
        player1=true;
        player2=false;
        player3=false;
        balon=false;
        terreno=false;
        siguientePregunta=false;
        contador=1;
        Bloques=FindObjectOfType<Opciones>();
        puntuacion=FindObjectOfType<Puntuacion1>();
        print(Bloques.NombreBloque);
        print(Bloques.Dificultad);
        NumeroJugadores=FindObjectOfType<AdministradorJugadores>();
        print(NumeroJugadores.Jugadores);
        NombreJugadores=NumeroJugadores.ListaJugadores;
        // foreach(GameObject jugador in ListadeJugadores){
        //     if(jugador.name==NombreJugadores[0]){
        //         jugador.transform.position=positionAvatar;
        //     //    jugador.SetActive(true);
        //     //    kinect.SetActive(true);

        //     }
        // }

        listaPreguntas1= new ListaPreguntas();
        if(Bloques.Dificultad.Equals("facil")){
        adm= new List<preguntas>(listaPreguntas1.AgregarPreguntasFaciles(Bloques.NombreBloque));
        }
        else if(Bloques.Dificultad.Equals("medio")){
        adm= new List<preguntas>(listaPreguntas1.AgregarPreguntasFaciles(Bloques.NombreBloque));
        }
        else if(Bloques.Dificultad.Equals("dificil")){
        adm= new List<preguntas>(listaPreguntas1.AgregarPreguntasFaciles(Bloques.NombreBloque));
        }
        numeroPreguntas=5;
        Secuencia();
    }

 void Update(){
     if(SiguientePregunta){
            Secuencia();
            SiguientePregunta=false;
     }

//      if (Veintiunabool){
//                      veintiUno();
//                      veintiunabool=false;
//     if(SiguienteCobro){
//         panel.SetActive(false);
//                      botonSeguir.SetActive(true);
// }

//                  }
 }
  void SetPreguntas(){

      for (int i=0; i<options.Length;i++){
          options[i].GetComponent<respuestas>().correcta=false;
          options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=adm[Preguntactual].respuestasSeleccion[i];
            if(adm[Preguntactual].respuestaCorrecta==i+1)
          {
              options[i].GetComponent<respuestas>().correcta=true;
          }
        
    }
 }
          void generarPregunta()
      {    
           Preguntactual= Random.Range(0, adm.Count);
           preguntaTxt.text =adm[Preguntactual].pregunta;
           SetPreguntas();      
        }  

        public void EliminarPregunta(){
            numeroiteraciones=numeroiteraciones+1;
            adm.RemoveAt(Preguntactual);
            //yield return new WaitForSeconds(8);
            print("entro a eliminar la pregunta");
            
            if(contador==1||contador==2){
                if(Respuesta){
                    puntuacion.PuntuacionJugador1+=5;
                }
            }
              if(contador==3){
                if(Respuesta){
                    puntuacion.PuntuacionJugador1+=10;
                }
                }
              if(contador==4){
                if(Respuesta){
                    puntuacion.PuntuacionJugador1+=15;
                }
            }
              if(contador==5){
                if(Respuesta){
                    puntuacion.PuntuacionJugador1+=20;
                }
            }

            print(Respuesta);
            // if(contador==1||contador==3||contador==5){
                 if(penalbool){
                    penal();
                    penalbool=false;
                    print("entro a el penal");
            
                 }
                  
            //      }
            //     else{
            //         penalBarrera();
            //     }
            // }
            // else if(contador==2||contador==4){
            //     if(Respuesta){
            //         veintiUno();
            //         print("entro veintiuna"+ contador);
            //     }
            //     else{
            //         veintiUnoRapido();
            //     }
                
            // }
            // if(numeroiteraciones==NumeroJugadores.ListaJugadores.Count){
            //     contador=contador+1;
            //      print("entro enumero de iteracion"+ contador);
            //     numeroiteraciones=0;
            // }

        }

        void Secuencia(){
            
            if(player1){
                textJugador.GetComponent<TextMeshProUGUI>().text = "Jugador: " + NombreJugadores[0];
                pregunta();
                // foreach(GameObject jugador in ListadeJugadores){
                //     jugador.transform.position=positionFinal;
                // // kinect.SetActive(false);
                // // jugador.SetActive(false);
                // if(jugador.name==NombreJugadores[1]){
                //     jugador.transform.position=positionAvatar;
                // // jugador.SetActive(true);
                // // kinect.SetActive(true);
                // }
            // }
                player1=false;
                player2=true;
                player3=false;
            }
            else if(player2 && NumeroJugadores.ListaJugadores.Count==2){
                textJugador.GetComponent<TextMeshProUGUI>().text = "Jugador: " + NombreJugadores[1];
                pregunta();
        //         foreach(GameObject jugador in ListadeJugadores){
        //             jugador.transform.position=positionFinal;
        //         //     kinect.SetActive(false);
        //         // jugador.SetActive(false);
        //        if(jugador.name==NombreJugadores[0]){
        //            jugador.transform.position=positionAvatar;
        //     //    jugador.SetActive(true);
        //     //    kinect.SetActive(true);
        //     }
        // }
                player1=true;
                player2=false;
                player3=false;
            }
             else if(player2 && NumeroJugadores.ListaJugadores.Count==3){
                textJugador.GetComponent<TextMeshProUGUI>().text =  "Jugador: " + NombreJugadores[1];
                pregunta();
            //      foreach(GameObject jugador in ListadeJugadores){
            //          jugador.transform.position=positionFinal;
            //         //  kinect.SetActive(false);
            //         // jugador.SetActive(false);
            //     if(jugador.name==NombreJugadores[2]){
            //         jugador.transform.position=positionAvatar;
            // //    jugador.SetActive(true);
            // //    kinect.SetActive(true);
            //     }
            // }
    
                player1=false;
                player2=false;
                player3=true;
            }
            else if(player3 && NumeroJugadores.ListaJugadores.Count==3){
                textJugador.GetComponent<TextMeshProUGUI>().text =  "Jugador: " + NombreJugadores[2];
                pregunta();
        //          foreach(GameObject jugador in ListadeJugadores){
        //              jugador.transform.position=positionFinal;
        //         //      kinect.SetActive(false);
        //         // jugador.SetActive(false);
        //         if(jugador.name==NombreJugadores[2]){
        //             jugador.transform.position=positionAvatar;
        //     //    jugador.SetActive(true);
        //     //    kinect.SetActive(true);
        //     }
        //  }
                player1=true;
                player2=false;
                player3=false;
            }
            else{
                //  foreach(GameObject jugador in ListadeJugadores){
                //      jugador.transform.position=positionFinal;
                // // jugador.SetActive(false);
                // // kinect.SetActive(false);
                // if(jugador.name==NombreJugadores[0]){
                //     jugador.transform.position=positionAvatar;
                // // jugador.SetActive(true);
                // // kinect.SetActive(true);
                // }
                // }
                player1=true;
                pregunta();
            }
        }




      public Vector3  PositionInicial  // property
     {
    get { return positionInicial; }
    set { positionInicial = value; }
    }

      public Vector3  PositionAvatar  // property
     {
    get { return positionAvatar; }
    set { positionAvatar = value; }
    }

      public Vector3  PositionFinal  // property
     {
    get { return positionFinal; }
    set { positionFinal = value; }
    }
        public bool  Respuesta  // property
     {
    get { return respuesta; }
    set { respuesta = value; }
    }
    

          public bool  SiguienteCobro  // property
     {
    get { return siguienteCobro; }
    set { siguienteCobro = value; }
    }

    
             public bool  Veintiunabool  // property
     {
    get { return veintiunabool; }
    set { veintiunabool = value; }
    }

            public bool  SiguientePregunta  // property
     {
    get { return siguientePregunta; }
    set { siguientePregunta = value; }
    }
     public void Puntuation(){
         if(Respuesta){

         }
     }

     private IEnumerator Esperar(){
         yield return new WaitForSeconds(8);
     }

     void penal(){
            panel.SetActive(false);
            back.SetActive(true);
            Ballpenalty.SetActive(true);
            front.SetActive(false);
            ContenedorVeintiuna.SetActive(false);
            BallVeintiuna.SetActive(false);
        }

     void penalBarrera(){
            panel.SetActive(false);
            back.SetActive(true);
            Ballpenalty.SetActive(true);
            front.SetActive(false);
            ContenedorVeintiuna.SetActive(false);
            BallVeintiuna.SetActive(false);
            if(Respuesta){
             panel.SetActive(false);
            }
            else{
                    panel.SetActive(false);
                 if(Bloques.Dificultad.Equals("facil")){
                     obstaculo1.SetActive(true);
            }
             else if(Bloques.Dificultad.Equals("medio")){
                obstaculo1.SetActive(true);
                obstaculo2.SetActive(true);
            }
                else if(Bloques.Dificultad.Equals("dificil")){
                    obstaculo1.SetActive(true);
                    obstaculo2.SetActive(true);
                    obstaculo3.SetActive(true);
                 }

            }
        
        }

     void pregunta(){
            panel.SetActive(true);
            generarPregunta();
        
        }

     void veintiUno(){
            // panel.SetActive(false);
            back.SetActive(false);
            Ballpenalty.SetActive(false);
            front.SetActive(true);
            ContenedorVeintiuna.SetActive(true);
            BallVeintiuna.SetActive(true);
            
        }
    void veintiUnoRapido(){
            panel.SetActive(false);
            terreno=true;
            balon=true;
        }

}
