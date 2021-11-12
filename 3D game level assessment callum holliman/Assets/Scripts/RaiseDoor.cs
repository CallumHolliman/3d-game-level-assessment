using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseDoor : MonoBehaviour 
{
    [SerializeField] private Rigidbody Football;
    [SerializeField] private Animator RaiseBridge;
    private void OnTriggerEnter(Collider other) {
        RaiseBridge.SetBool("EnterBridgeTrigger", false);
    }



    private void OnTriggerExit(Collider other) {    //leaving trigger causes ball to fall from the air
        if (other.CompareTag("Player")) {
            Football.useGravity = true;
        }
    }
}
