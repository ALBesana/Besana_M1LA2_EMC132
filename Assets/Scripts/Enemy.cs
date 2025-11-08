using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int scoreValue = 1;
    public AudioClip deathSound;
    private AudioSource audioSource;
    private bool isDead = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Die()
    {
        if (isDead) return;
        isDead = true;
        
        ScoreManager.instance.AddScore(scoreValue);

        if (deathSound)
            AudioSource.PlayClipAtPoint(deathSound, transform.position);

        Destroy(gameObject);
    }
}