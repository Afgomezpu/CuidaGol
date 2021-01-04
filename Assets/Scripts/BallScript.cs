using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

    float time;
    float distance;
    float angle;
    float initialVelocity;
    float finalVelocity;
    float force;
    float mass = 15f;
    float acceleration;


    public static string goal = null;
    void Start()
    {
        
    }
    public void KickForce(float[] param)
    {
        print("entro el kick");
        time = param[0];
        distance = param[1];
        angle = param[2];
        initialVelocity = param[3];
        finalVelocity = param[4];


        acceleration = (finalVelocity - initialVelocity) / time;
        force = mass * finalVelocity;
        if (force < 5)
        {
            force = 18;
        }
        else
        {
            force = 30;
        }
        transform.GetComponent<Rigidbody>().AddForce(force * new Vector3(angle, 0.2f, 1) * 55);
        Debug.Log(force);
    
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Goal")
        {
            goal = "Goal";
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 200, 100), goal);
    }
}
