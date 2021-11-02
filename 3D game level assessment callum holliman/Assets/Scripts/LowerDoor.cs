using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerDoor : MonoBehaviour
{
    [SerializeField] private Animator LowerBridge;

    private void OnTriggerEnter(Collider other) {
        LowerBridge.SetBool("EnterBridgeTrigger", true);
    }
}
