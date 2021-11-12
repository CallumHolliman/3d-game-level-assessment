using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingDoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator rotatingDoor;

    private void OnTriggerExit(Collider other) {
        if (other.tag == ("Player")) {
            rotatingDoor.SetBool("ClickRotatingDoor", false);
        }
    }
}
