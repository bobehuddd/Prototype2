using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30; //anjing akan hilang di jarak x = -30
    private float lowerLimit = -5; //bola akan hilang di jarak y = -5

    // Update is called once per frame
        private void Update()
    {
        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
