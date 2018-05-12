using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

    GameObject pogodjeniHex;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if(Physics.Raycast(ray,out hitInfo))
        {
            //komad koda za hower preko hexa
            /*if(pogodjeniHex==hitInfo.collider.transform.gameObject)
            {
                pogodjeniHex.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
            }
            else if(pogodjeniHex!=null)
            {
                pogodjeniHex.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
            }*/
            GameObject ourHitObject = hitInfo.collider.transform.gameObject;
            

            if(Input.GetMouseButtonDown(0))
            {
                MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer>();
                if(mr.material.color==Color.red)
                {
                    mr.material.color = Color.white;
                }
                else
                {
                    mr.material.color = Color.red;
                }
                
            }
            //hitInfo.transform.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("hittt  "+ourHitObject.name);
            pogodjeniHex = ourHitObject;
        }
        

    }
}
