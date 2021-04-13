using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Animation1 : MonoBehaviour
{
    public GameObject Timeline;
    private void OnTriggerEnter(Collider other)
    {
        Timeline.GetComponent<PlayableDirector>().Play();
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
    }

}
