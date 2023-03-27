using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] 
    private Vector3 point1;

    [SerializeField] 
    private Vector3 point2;

    private CameraMover mover;

    [SerializeField]
    private Transform targetTransform;

    void Start() {
        mover = new CameraMover(point1, point2);
        transform.position = point1;
        
    }

    // Update is called once per frame
    void Update() {
        if(!mover.Complete()) {
            transform.position = mover.Move();
            transform.LookAt(targetTransform);
        }
        
    }
}
