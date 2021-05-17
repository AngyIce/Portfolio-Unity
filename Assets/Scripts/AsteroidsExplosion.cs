using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsExplosion : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            gameObject.SetActive(false);
        }
    }
}
