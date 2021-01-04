using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{   Administradortest admin;
    fuerza fuerza1;
    //Arquero Arquero1;
    Vector3 direccion;
    int Quieto;
    public TextMeshProUGUI ball;
    Vector3 positionInitial;
    
    void Start()
    {
        fuerza1 = GameObject.Find("Addforce").GetComponent<fuerza>();
        // Arquero1 = GameObject.Find("Arquero").GetComponent<Arquero>();
        admin=GameObject.Find("Administradortest").GetComponent<Administradortest>();
        positionInitial=transform.position;
        admin.PositionInicial=transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnTriggerEnter(Collider other)

    {    
        Quieto=Random.Range(2,3);
        if (other.name == "joint_ToeRT"){
            fuerza1.Disparo=true;
           // Arquero1.PrimeraAnimacion=Quieto;

        }

        if (other.name == "joint_ToeLT"){
            fuerza1.Disparo=true;
          //  Arquero1.PrimeraAnimacion=Quieto;
        }

        if (other.name == "Goalie"){
            fuerza1.Disparo=true;
        }

        if (other.name == "joint_HipRT"){
            fuerza1.Direction=other.transform.position;
            fuerza1.Disparo1=true;
           // Arquero1.PrimeraAnimacion=4;
        }
        if (other.name == "joint_HipLT"){
            fuerza1.Disparo2=true;
 //           Arquero1.PrimeraAnimacion=5;
        }



        }
    

          void OnTriggerExit(Collider other)
    {   
         if (other.name == "Goalie"){
             fuerza1.Disparo=false;
        }
        if (other.name == "joint_ToeRT"){
            fuerza1.Disparo=false;
        }

        if (other.name == "joint_ToeLT"){
            fuerza1.Disparo=false;
        }

        if (other.name == "joint_HipRT"){
            fuerza1.Disparo1=false;
        }
        if (other.name == "joint_HipLT"){
            fuerza1.Disparo2=false;
        }
        }


        
        void OnCollisionEnter(Collision collision)
     {
        //  if(collision.gameObject.name=="U_CharacterBack"){

         print(collision.gameObject.name);
        //  fuerza1.Disparo=true;
        // direccion=transform.position -collision.gameObject.transform.position;
        // // direccion.Normalize();
        // fuerza1.Direction=direccion;
        //  }


          if(collision.gameObject.name=="Cube (5)"){
            print(collision.gameObject.name);
            //Arquero1.SeguirCelebracion=2;
            ball.text="Gol!";
            StartCoroutine("Esperar");
            admin.SiguienteCobro=true;
            // transform.rotation=Quaternion.Euler(0,0,0);
            // this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
            // transform.position=positionInitial;
            admin.SiguientePregunta=true;
            admin.botonSeguir.SetActive(true);
            ball.text="";
         }

         if(collision.gameObject.name=="Arque"){
             ball.text="Atajado!";
            // Arquero1.SeguirCelebracion=3;
             StartCoroutine("Esperar");
             admin.SiguienteCobro=true;
             admin.botonSeguir.SetActive(true);
            //  transform.rotation=Quaternion.Euler(0,0,0);
            //  this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
            // transform.position=positionInitial;

            admin.SiguientePregunta=true;
            ball.text="";
             }

        if(collision.gameObject.name=="Cube (1)"||collision.gameObject.name=="Cube (3)"||collision.gameObject.name=="CuboAtras"
           ||collision.gameObject.name=="CuboIzquierda" ||collision.gameObject.name=="CuboDerecha"){
            print(collision.gameObject.name);
           ball.text="Fuera!";
           admin.botonSeguir.SetActive(true);
         //  Arquero1.SeguirCelebracion=3;
           StartCoroutine("Esperar");
           admin.SiguienteCobro=true;
           
        //    transform.rotation=Quaternion.Euler(0,0,0);
        //    this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
        //    transform.position=positionInitial;
           admin.Veintiunabool=true;
           ball.text="";

         }
         


        //  Quieto=Random.Range(2,3);
        // if (collision.gameObject.name == "joint_ToeRT"){
        //     fuerza1.Disparo=true;
        //     Arquero1.PrimeraAnimacion=Quieto;

        // }

        // if (collision.gameObject.name == "joint_ToeLT"){
        //     fuerza1.Disparo=true;
        //     Arquero1.PrimeraAnimacion=Quieto;
        // }

        // if (collision.gameObject.name == "Goalie"){
        //     fuerza1.Disparo=true;
        // }

        // if (collision.gameObject.name == "joint_HipRT"){
        //     fuerza1.Disparo1=true;
        //     Arquero1.PrimeraAnimacion=4;
        // }
        // if (collision.gameObject.name == "joint_HipLT"){
        //     fuerza1.Disparo2=true;
        //     Arquero1.PrimeraAnimacion=5;
        // }
     }
     private IEnumerator Esperar(){
         yield return new WaitForSeconds(8);
     }

}



