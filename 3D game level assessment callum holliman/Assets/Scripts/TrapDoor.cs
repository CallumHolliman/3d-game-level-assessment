using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    [SerializeField] private Animator trapDoorAni;

    private void OnMouseDown() {
        trapDoorAni.SetBool("PressTrapButton", true);
    }
}
