using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator fadeAnimator;
    public AudioSource audioSource;

    public GameObject[] gas;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorAnimator.SetBool("PlayerTrigger", true);
            audioSource.Play();
            fadeAnimator.SetBool("PlayerTrigger02", true);

            for (int i = 0; i < gas.Length; i++)
            {
                gas[i].gameObject.SetActive(false);
            }
        }
    }
}
