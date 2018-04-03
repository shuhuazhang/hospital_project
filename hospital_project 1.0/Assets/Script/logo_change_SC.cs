using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo_change_SC : MonoBehaviour {
    public Vector3 rotoation_speed=new Vector3(0f,1f,0f) ;
	// Use this for initialization
	void Start () {
        GameObject logo = this.gameObject;  
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.eulerAngles += rotoation_speed;
    }
    
}
