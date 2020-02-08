using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make camera position follow player position
public class CameraController : MonoBehaviour {

    [SerializeField] private GameObject player;       

    void LateUpdate () 
    {
        transform.position = player.transform.position + new Vector3(0,0,-1.0f); // offset Z otherwise it hides some 2D objects
    }
}