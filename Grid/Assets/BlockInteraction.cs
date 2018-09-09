using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInteraction : MonoBehaviour 
{
    bool isEmpty = true;

	// Use this for initialization
	void Start () 
    {
        
	}



    public void OnMouseOver()
    {
        if (isEmpty)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }


    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

}
