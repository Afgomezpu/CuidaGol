using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arquero : MonoBehaviour
{
    // public GameObject Target;
    // UnityEngine.AI.NavMeshAgent Agent;
    // Vector3 posicionTarget;
    // Vector3 EstaticoAgent;
     Vector3 InitialPosition;
     Vector3 Actualizarrecorrido;
     Vector3 PositionFinal;
    // GoalieAI goalie;
    public Transform target;
    public float speed;
    private bool seguir;
    private int primeraAnimacion;
     private int seguirCelebracion;
    int Quieto;

    void Start()
    {   Seguir=false;
        // this.Agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.InitialPosition = this.gameObject.transform.position;
        Actualizarrecorrido.x=InitialPosition.x;
        primeraAnimacion=1;
        
        
        // goalie = GameObject.Find("Goalie").GetComponent<GoalieAI>();
    }

 void Update() {
        transform.rotation=Quaternion.Euler(0,0,0);
         Actualizarrecorrido.z=target.transform.position.z;
         Actualizarrecorrido.y=target.transform.position.y+0.16f;
         float step = speed ;
         transform.position = Vector3.MoveTowards(Actualizarrecorrido, target.position, step);
          if(Seguir){
            PositionFinal=InitialPosition;
            PositionFinal.y =PositionFinal.y +0.20f;
           transform.position=InitialPosition;
       }
      //  if(PrimeraAnimacion>3){
      //      Quieto=Random.Range(2,3);
      //      this.GetComponent<Animator>().SetInteger("EstadoInicial",PrimeraAnimacion);
      //      this.GetComponent<Animator>().SetInteger("Segundo", Quieto);
      //    if(SeguirCelebracion==2||seguirCelebracion==3){
      //        this.GetComponent<Animator>().SetInteger("Celebracion", SeguirCelebracion);
      //        transform.position=InitialPosition;
      //        SeguirCelebracion=0;
      //        PrimeraAnimacion=0;

      //  }}
      //   else if(PrimeraAnimacion==2 ||PrimeraAnimacion==3){
      //        this.GetComponent<Animator>().SetInteger("EstadoInicial",PrimeraAnimacion);
      //        if(SeguirCelebracion==2||seguirCelebracion==3){
      //        this.GetComponent<Animator>().SetInteger("Celebracion", SeguirCelebracion);
      //       transform.position=InitialPosition;
      //        SeguirCelebracion=0;
      //        PrimeraAnimacion=0;
      //   }
    //  }
}
    
    void OnTriggerEnter(Collider other){
        print(other.name);
        if(other.name!="Terrain"){
            print(other.name);
        }
        if(other.name=="Cube (1)"||other.name=="Cube (3)"||other.name=="Cube (4)"){
            Seguir=true;
        }
    }

   void OnCollisionEnter(Collision collision){
      print(collision.gameObject.name);

       if(collision.gameObject.name=="Cube (1)"||collision.gameObject.name=="Cube (3)"||collision.gameObject.name=="Cube (4)"){
            Seguir=true;
        }
}

           public int  PrimeraAnimacion   // property
  {
    get { return primeraAnimacion; }
    set { primeraAnimacion = value; }
  }
  

              public int  SeguirCelebracion   // property
  {
    get { return seguirCelebracion; }
    set { seguirCelebracion = value; }
  }

          public bool  Seguir   // property
  {
    get { return seguir; }
    set { seguir = value; }
  }

}
