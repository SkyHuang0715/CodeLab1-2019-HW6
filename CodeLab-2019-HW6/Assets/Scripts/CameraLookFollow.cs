using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//USAGE: plug this on a object that looks at stuff(ideally, camera)
//PURPOSE: this will make the thing look at a thing, forever

public class CameraLookFollow : MonoBehaviour
{
    public Transform lookTarget;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lookTarget == null)
        {
            return;
        }
 
        //technique 1: use lookAt, basic idea
               //transform.LookAt( lookTarget );
               
        //technique 2: use Quaternions to make the thing look at 
        Vector3 forward = lookTarget.position - transform.position;
        //calculate quaternion based on the forward vector desired
        Quaternion targetRotation = Quaternion.LookRotation(forward);
        
        //change the rotation based on quaternions
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 30f * Time.deltaTime);
        
        //more organic feel, eases in and out/ dampens/ accelerates 你还记得你的咸鱼群吗hh
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
    }
}
