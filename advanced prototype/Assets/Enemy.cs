using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform target;
    public Transform mytransform; 


    private void Update()
    {
        transform.LookAt(target);
		if (Vector3.Distance (transform.position, target.position) > 0.5f) { 
			transform.Translate (Vector3.forward * 5 * Time.deltaTime);
		}
    }
  }
