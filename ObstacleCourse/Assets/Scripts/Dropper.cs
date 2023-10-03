using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //Κάνω reference
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField]float time = 3f;


    // Start is called before the first frame update
    void Start()
    {
        //renderer εμφανίζει τον κύβο
        //rigidbody ρίχνει τον κύβο στο πάτωμα
        renderer = GetComponent<MeshRenderer>(); 
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > time)
        {
            //Debug.Log(time + " seconds have elapsed");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
