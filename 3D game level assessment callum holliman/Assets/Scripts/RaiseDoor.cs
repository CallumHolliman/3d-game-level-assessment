using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseDoor : MonoBehaviour 
{
    [SerializeField] private Animator RaiseBridge;
    private void OnTriggerEnter(Collider other) {
        RaiseBridge.SetBool("EnterBridgeTrigger", false);
    }
}
