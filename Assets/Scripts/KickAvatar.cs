using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickAvatar : MonoBehaviour
{
    fuerza fuerza1;
    Vector3 direccion;
    void Start()
    {
        fuerza1 = GameObject.Find("Addforce").GetComponent<fuerza>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

         void OnCollisionEnter(Collision collision)
     {
         if(collision.gameObject.name=="Ball"){
         print(collision.gameObject.name);
         fuerza1.Disparo=true;
        direccion=transform.position-collision.gameObject.transform.position;
        direccion.Normalize();
        fuerza1.Direction=direccion;
         }

}
}
