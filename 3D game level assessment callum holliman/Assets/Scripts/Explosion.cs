using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject[] boxes;
    private void OnMouseDown() {
        foreach (GameObject box in boxes) { //causes all boxes to expload
            box.GetComponent<Rigidbody>().AddExplosionForce(450.0f, gameObject.transform.position, 50f, 10f, ForceMode.Impulse);
        }
    }
}
