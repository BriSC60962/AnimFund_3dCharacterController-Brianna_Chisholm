using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Animation2 : MonoBehaviour
{
    public GameObject Fire;

    private void OnTriggerEnter(Collider other)
    {
        Fire.GetComponent<PlayableDirector>().Play();
    }
}
