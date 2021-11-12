using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingDoorClick : MonoBehaviour
{
    [SerializeField] private Animator rotatingDoor;

    private void OnMouseDown() {
        rotatingDoor.SetBool("ClickRotatingDoor", true);
    }
}
