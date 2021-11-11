using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideDoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator OpenDoor;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == ("Player")) {
            OpenDoor.SetBool("EnterDoorTrigger", true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == ("Player")) {
            OpenDoor.SetBool("EnterDoorTrigger", false);
        }
    }
}
