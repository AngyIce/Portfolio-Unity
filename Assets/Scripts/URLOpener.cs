using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string URL;
    private bool isOpened = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile") && (isOpened == false))
        {
           // Application.OpenURL(URL);
            isOpened = true;
        }     
    }
}
