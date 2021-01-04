using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerza : MonoBehaviour
{
    [SerializeField]
    private GameObject Objetofuerza;
    float velocidadDisparo;
    private bool disparo;
    private Vector3 direction;
    private bool disparo1;
    private bool disparo2;
    float fuerazaMagnitud;
    float  xPositiva;
    float  xNegativa;
    Vector3 directionReal;
    float y;
    
    void Start()
    {
         disparo=false;
         disparo1=false;
         disparo2=false;
         direction=new Vector3();
         directionReal=new Vector3();
         fuerazaMagnitud=Random.Range(1,3);
         xPositiva=Random.Range(1,3);
         xNegativa=Random.Range(-3,-1);
         y=Random.Range(1,2);

    } 
    void Update()
    
    
    { 
      // if(disparo){
      //   Objetofuerza.GetComponent<Rigidbody>().AddForce(Direction*1f,ForceMode.Impulse);
      // }

      
        if(disparo){
       // Objetofuerza.GetComponent<Rigidbody>().AddForce(new Vector3(0,y,1)*fuerazaMagnitud,ForceMode.Impulse);
        Objetofuerza.GetComponent<Rigidbody>().AddForce(new Vector3(1,y,0)*fuerazaMagnitud,ForceMode.Impulse);

        }

        if(disparo1){
          Objetofuerza.GetComponent<Rigidbody>().AddForce(new Vector3(1,y,xPositiva)*fuerazaMagnitud,ForceMode.Impulse);
       // Objetofuerza.GetComponent<Rigidbody>().AddForce(new Vector3(xNegativa,y,1)*fuerazaMagnitud,ForceMode.Impulse);
    
        }

        if(disparo2){
        //Objetofuerza.GetComponent<Rigidbody>().AddForce(new Vector3(xPositiva,y,1)*fuerazaMagnitud,ForceMode.Impulse);
        Objetofuerza.GetComponent<Rigidbody>().AddForce(new Vector3(1,y,xNegativa)*fuerazaMagnitud,ForceMode.Impulse);
        
        }
      
    }

       public bool Disparo   // property
  {
    get { return disparo; }
    set { disparo = value; }
  }

       public bool Disparo1   // property
  {
    get { return disparo1; }
    set { disparo1 = value; }
  }

       public bool Disparo2   // property
  {
    get { return disparo2; }
    set { disparo2 = value; }
  }
 
        public Vector3 Direction   // property
  {
    get { return direction; }
    set { direction = value; }
  }

}
