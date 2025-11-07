using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int scoreValue = 1;
    public AudioClip deathSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Die()
    {
        ScoreManager.instance.AddScore(scoreValue);
        if (deathSound && audioSource)
            audioSource.PlayOneShot(deathSound);

        Destroy(gameObject);
    }
}