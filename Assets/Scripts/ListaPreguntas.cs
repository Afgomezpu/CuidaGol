using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaPreguntas : MonoBehaviour
{

    // preguntas[] preguntasFaciles;
    public List<preguntas> preguntasFaciles= new List<preguntas>();


    public List<preguntas> AgregarPreguntasFaciles(string bloque){

      if(bloque.Equals("Bloque1")){
       preguntas pregunta1= new preguntas();
       pregunta1.pregunta="El mayor porcentaje de energía eléctrica que produce CHEC es:";
       string[] listarespuestas=new string[4]{"Geotérmica (Volcán) ", "Solar", "Hidroeléctrica", "Fredy Pulgarin "};
         pregunta1.respuestasSeleccion=listarespuestas;
       pregunta1.respuestaCorrecta=3;
       preguntasFaciles.Add(pregunta1);
       preguntas pregunta2= new preguntas();
       pregunta2.pregunta="Para producir energía eléctrica se pueden utilizar recursos de la naturaleza como:";
       string[] listarespuestas2=new string[4]{"Recursos Renovables", "Recursos Renovables y No Renovables", "Biomasa", "56"};
         pregunta2.respuestasSeleccion=listarespuestas2;
       pregunta2.respuestaCorrecta=2;
       preguntasFaciles.Add(pregunta2);
       preguntas pregunta3= new preguntas();
       pregunta3.pregunta="CHEC para aportar a la conservación del recurso hídrico, protege los Ríos";
       string[] listarespuestas3=new string[4]{"Chinchiná, Campo Alegre y San Francisco", "Rio Claro, Quebrada Olivares", "Rio Chinchiná", "Cable"};
         pregunta3.respuestasSeleccion=listarespuestas3;
       pregunta3.respuestaCorrecta=3;
       preguntasFaciles.Add(pregunta3);
       preguntas pregunta4= new preguntas();
        pregunta4.pregunta="Desde el año 2001 se fomenta el Programa URE que significa";
       string[] listarespuestas4=new string[4]{"Uso de energías limpias", "Uso responsable de la energía", "Uso Racional y Eficiente de la Energía", "programacion"};
         pregunta4.respuestasSeleccion=listarespuestas4;
       pregunta4.respuestaCorrecta=3;
      //  preguntasFaciles.Add(pregunta4);
      //  preguntas pregunta5= new preguntas();
      //  pregunta5.pregunta="Que te gusta hacer ";
      //  string[] listarespuestas5=new string[4]{"pasear", "caminar", "bailar", "tomar"};
      //    pregunta5.respuestasSeleccion=listarespuestas5;
      //  pregunta5.respuestaCorrecta=1;
      //  preguntasFaciles.Add(pregunta5);
      //  preguntas pregunta6= new preguntas();
      //  pregunta6.pregunta="Cual es tu musica favorita";
      //  string[] listarespuestas6=new string[4]{"salsa", "bachata", "regaetton", "cumbia"};
      //    pregunta6.respuestasSeleccion=listarespuestas6;
      //  pregunta6.respuestaCorrecta=1;
      //  preguntasFaciles.Add(pregunta6);
      //  preguntas pregunta7= new preguntas();
      //     pregunta7.pregunta="Que estas estudiando?";
      //  string[] listarespuestas7=new string[4]{"Medicina", "Filosofia", "Matematicas", "programacion"};
      //    pregunta7.respuestasSeleccion=listarespuestas7;
      //  pregunta7.respuestaCorrecta=1;
      //  preguntasFaciles.Add(pregunta7);
      //  preguntas pregunta8= new preguntas();
      //  pregunta8.pregunta="Que te gusta hacer ";
      //  string[] listarespuestas8=new string[4]{"pasear", "caminar", "bailar", "tomar"};
      //    pregunta8.respuestasSeleccion=listarespuestas8;
      //  pregunta8.respuestaCorrecta=1;
      //  preguntasFaciles.Add(pregunta8);
      //  preguntas pregunta9= new preguntas();
      //  pregunta9.pregunta="Cual es tu musica favorita";
      //  string[] listarespuestas9=new string[4]{"salsa", "bachata", "regaetton", "cumbia"};
      //    pregunta9.respuestasSeleccion=listarespuestas9;
      //  pregunta9.respuestaCorrecta=1;
      //  preguntasFaciles.Add(pregunta9);
      }
        else if(bloque.Equals("Bloque2")){
       preguntas pregunta1= new preguntas();
       pregunta1.pregunta="Que estas estudiando?";
       string[] listarespuestas=new string[4]{"Medicina", "Filosofia", "Matematicas", "programacion"};
         pregunta1.respuestasSeleccion=listarespuestas;
       pregunta1.respuestaCorrecta=1;
       preguntasFaciles.Add(pregunta1);
       preguntas pregunta2= new preguntas();
       pregunta2.pregunta="Que te gusta hacer ";
       string[] listarespuestas2=new string[4]{"pasear", "caminar", "bailar", "tomar"};
         pregunta2.respuestasSeleccion=listarespuestas2;
       pregunta2.respuestaCorrecta=1;
       preguntasFaciles.Add(pregunta2);
       preguntas pregunta3= new preguntas();
       pregunta3.pregunta="Cual es tu musica favorita";
       string[] listarespuestas3=new string[4]{"salsa", "bachata", "regaetton", "cumbia"};
         pregunta3.respuestasSeleccion=listarespuestas3;
       pregunta3.respuestaCorrecta=1;
       preguntasFaciles.Add(pregunta3);
      }
        else if (bloque.Equals("Bloque3")){
       preguntas pregunta1= new preguntas();
       pregunta1.pregunta="Que tipo de trago te gusta";
       string[] listarespuestas=new string[4]{"Ron ", "Aguardiente", "gamaiquino", "Vodka"};
         pregunta1.respuestasSeleccion=listarespuestas;
       pregunta1.respuestaCorrecta=1;
       preguntasFaciles.Add(pregunta1);
       preguntas pregunta2= new preguntas();
       pregunta2.pregunta="En que pais vives";
       string[] listarespuestas2=new string[4]{"Colombia", "mexico", "venezuela", "ecuador"};
         pregunta2.respuestasSeleccion=listarespuestas2;
       pregunta2.respuestaCorrecta=1;
       preguntasFaciles.Add(pregunta2);
       preguntas pregunta3= new preguntas();
       pregunta3.pregunta="Cual es tu equipo preferido";
       string[] listarespuestas3=new string[4]{"Once caldas", "America", "Nacional", "Medellin"};
         pregunta3.respuestasSeleccion=listarespuestas3;
       pregunta3.respuestaCorrecta=1;
       preguntasFaciles.Add(pregunta3);
      }
  
        return preguntasFaciles;
    }
}

