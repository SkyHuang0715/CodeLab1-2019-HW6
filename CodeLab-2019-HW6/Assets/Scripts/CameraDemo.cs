using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//USAGE: put on your main camera
//PURPOSE: demo camera control techniques, like simple mouse look/ following target
public class CameraDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //simple mouse look
       
       //1.get mouse input
       float horizontalMouseSpeed = Input.GetAxis("Mouse X");
       float verticalMouseSpeed = Input.GetAxis("Mouse Y");
       //Debug.Log(horizontalMouseSpeed);//test if it works
       
       
       //2. use mouse import to rotate camera
       transform.Rotate(0f, horizontalMouseSpeed, 0f);
       Camera.main.transform.Rotate(verticalMouseSpeed,0f,0f);
       
       //3. unroll the camera, always set its z angle to 0
       transform.eulerAngles = new Vector3(transform.eulerAngles.x,
                                           transform.eulerAngles.y,
                                           0f);
    }
}
