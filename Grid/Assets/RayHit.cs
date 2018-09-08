using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayHit : MonoBehaviour 
{ 
    //Put this script on camera

    public float rayLength;
    public LayerMask layerMask;


     void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject( ))
        {
            RaycastHit hit; // куда записывается инфа в случае попадания
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                Debug.Log(hit.collider.name);





                //if (hit.collider != null)
                //{
                 //   Debug.Log("HIT");
                //}
            }
        }

    }
}


//   string targetX = Convert.ToString(hit.collider.transform.position.x);
// string targetZ = Convert.ToString(h.collider.transform.position.z);

// Debug.Log(targetX + "  " + targetZ);