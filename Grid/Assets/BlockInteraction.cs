using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockInteraction : MonoBehaviour
{
    bool isEmpty = true;

   

    #region Change Color if mouse over
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
#endregion 


}
