using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//USAGE: put this on an object w/ collider to make it clickable
//FUNCTION: shoot rayCast based on mouse cursor to detect any collider

public class RaycastButton : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //STEP 1: generate a "Ray" variable
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        //STEP 2: draw a rayCast in debug scene view
        Debug.DrawRay(myRay.origin, myRay.direction * 5f, Color.cyan);

        //STEP 3: initialize a RaycastHit variable
        RaycastHit myRaycastHitInfo = new RaycastHit();

        if (Input.GetMouseButtonDown(0))
        {
            //STEP 4: actually shoot raycast now
            if (Physics.Raycast(myRay, out myRaycastHitInfo, 5f))
            {
                //STEP 5: do something with the raycast
                //Destroy(myRaycastHitInfo.collider.gameObject);

                myRaycastHitInfo.transform.GetComponent<Renderer>().material.color = new Color(Random.Range(0.5f,1), Random.Range(0.5f,1), Random.Range(0.5f,1)) ;
                print(myRaycastHitInfo.transform.GetComponent<Renderer>().material.color);

            }
        }
    }

    void OnMouseDown()
    {
        Debug.Log("You clicked me!");
        
    }
}
