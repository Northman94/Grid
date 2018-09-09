using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayHit : MonoBehaviour 
{ 
    //Put this script on camera

  //  public float rayLength;
    public LayerMask layerMask;


     void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject( ))
        {
            RaycastHit hit; // stores if hit info
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // It's important to change Camera Tag to: MAIN CAMERA

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                //Debug.Log(hit.collider.name);
             
                if (hit.collider != null)
                {
                    Vector3 w = hit.point;
                    Debug.Log("HIT");
                    Debug.Log("X = " + w.x);
                    Debug.Log("Z = " + w.z);
                }
            }
        }

    }
}


//   string targetX = Convert.ToString(hit.collider.transform.position.x);
// string targetZ = Convert.ToString(h.collider.transform.position.z);

// Debug.Log(targetX + "  " + targetZ);