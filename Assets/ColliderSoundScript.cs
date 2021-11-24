using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSoundScript : MonoBehaviour
{
    private AudioSource tickSource;
    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision){
        tickSource.Play();
        Debug.Log("HAMMER HIT");
    }
}
