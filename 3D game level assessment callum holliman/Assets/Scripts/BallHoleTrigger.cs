using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHoleTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == ("Ball")) {
            winText.SetActive(true);
        }
    }
}
