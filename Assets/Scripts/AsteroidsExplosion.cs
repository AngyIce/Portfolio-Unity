using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsExplosion : MonoBehaviour
{
    public GameObject spawnObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            gameObject.SetActive(false);
            Instantiate(spawnObject, transform.position += Vector3.up * 5.0f, transform.rotation);
        }
    }
}
