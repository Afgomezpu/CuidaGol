using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veintiuna : MonoBehaviour
{
    private Vector3 valor;
    bool ejecutar;
    public float fuerazaMagnitud=4f;
    int contador;
    Administradortest admin;

    void Start()
    {  
        admin=GameObject.Find("Administradortest").GetComponent<Administradortest>();
        ejecutar=false;
    }

    // Update is called once per frame
    void Update()
    
    { 

      // if(ejecutar){
      //   this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
      //   this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0.3f,0)*fuerazaMagnitud,ForceMode.Impulse);
      // }
        // // if(ejecutar){
        // BalonVeintiuna.GetComponent<Rigidbody>().velocity=Vector3.zero;
        // BalonVeintiuna.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0),ForceMode.Impulse);
        // }
      //   valor=transform.position;
      // if(transform.position.x<=1.3|| transform.position.x>=4.3){
      //   valor.x=2.84f;
      //  transform.position=valor;
      // }
      //   if(transform.position.y<=0||transform.position.y>=7.1){
      //   valor.y=3.44f;
      //  transform.position=valor;
      // }

      //  if(transform.position.z<=3 || transform.position.z>=5){
      //   valor.z=4.0f;
      //  transform.position=valor;
      // }
    }

    void OnTriggerEnter(Collider other){
        // if(other.name!=terrain||other.name!=estadio){
          contador=contador+1;
        // }
        print(other.name);
        this.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*fuerazaMagnitud,ForceMode.Impulse);

        if(contador>=10){
          // admin.SiguientePregunta=true;
          admin.SiguienteCobro=true;

          contador=0;
        }

      //  if (other.name == "joint_ToeRT"||other.name == "joint_ToeLT"){
      //     ejecutar=true;
      //   }

        
      // print(other.name);
      // ejecutar=true;
    }

     void OnTriggerExit(Collider other)
    {   
        //  if (other.name == "joint_ToeRT"||other.name == "joint_ToeLT"){
            //  ejecutar=false;
        // }
    }
}
