using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private ParticleSystem _dust;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            _dust.Play();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _dust.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _dust.Stop();
        }
    }
}
