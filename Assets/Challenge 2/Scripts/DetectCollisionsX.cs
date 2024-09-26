using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
{
    // Buat bola-bola hanya dihancurkan ketika bersentuhan langsung dengan anjing
    if (other.gameObject.tag == "Dog")
    {
        Destroy(gameObject);
    }
}
}
