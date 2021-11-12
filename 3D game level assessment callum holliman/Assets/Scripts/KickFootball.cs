using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickFootball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) { //adds impulse force to ball when player collides with ball
        if (collision.gameObject.tag == ("Player")) {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(0, 0, 7f, ForceMode.Impulse);
        }
    }
}

