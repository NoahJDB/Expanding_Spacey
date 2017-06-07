using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderP : MonoBehaviour {


    public double faster =1;
    public double higher =1;
    private float n = 0;
    private float timeQuee;
    public float timeJump;
    public float timeSpeed;


    void OnTriggerEnter(Collider detect)
    {
        if (detect.tag == "Speed")
        {
            faster = 1.6;
            print("too fast");
            Destroy(detect.gameObject);
            timeSpeed = Time.time + 22;
        }
        
        if(detect.tag == "Jump")
        {
            higher = 1.5;
            print("too high");
            Destroy(detect.gameObject);
            timeJump = Time.time + 22;
        }
        
        
    }
    
}
