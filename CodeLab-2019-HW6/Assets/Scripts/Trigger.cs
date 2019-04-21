using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

	public GameObject myplayer;
    // Start is called before the first frame update
    void Start()
    {
        myplayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    		{
    	
    			
    	
    			//print("I GOT HIT");
    			if (other.gameObject.CompareTag("Player"))//if the collider attached the prize
    			{
	                
	                //other.gameObject.GetComponent<PlayerController>().score+= 10; //Get the PlayerController and add 10 score
    				Destroy(gameObject); //Destroy the gameObject I am attached to
                    print("You find my carrot! YEY");
    			}
    		}
}
