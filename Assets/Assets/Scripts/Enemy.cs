using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Transform target;
    private float speed = .03f;
    private float MinDist = 2.5f;

    void Start () {
        target = GameObject.FindWithTag("Player").transform;
    }
 
    void Update(){
        if (target != null) {
            transform.right = target.position - transform.position;

            if (Vector3.Distance(transform.position,target.position) >= MinDist) {
                transform.Translate(speed, 0 , 0);
            }
        }
    }
}
