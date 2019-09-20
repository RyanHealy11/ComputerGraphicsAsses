using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float turnSpeed = 10.0f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Aiming();
       
    }
    public void Aiming()
    {
        Vector3 rot = new Vector3(0f, 0f, 0f);
        if(Input.GetAxis("Mouse X") < 0)
        {
            rot.y -= 1;
        }if(Input.GetAxis("Mouse X") > 0)
        {
            rot.y += 1;
        }if(Input.GetAxis("Mouse Y") < 0)
        {
            rot.x += 1;
        }if(Input.GetAxis("Mouse Y") > 0)
        {
            rot.x -= 1;
        }

        transform.Rotate(rot, turnSpeed * Time.deltaTime);
    }
}
