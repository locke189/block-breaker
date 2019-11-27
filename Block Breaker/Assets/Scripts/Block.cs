using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    // config
    [SerializeField] AudioClip[] brickSounds;
    Level level;

    // components
    AudioSource localAudioSource;
    SpriteRenderer localSpriteRenderer;
    BoxCollider2D localBoxCollider2D;

    private void Start()
    {
        localAudioSource = GetComponent<AudioSource>();
        localSpriteRenderer = GetComponent<SpriteRenderer>();
        localBoxCollider2D = GetComponent<BoxCollider2D>();
        level = FindObjectOfType<Level>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioClip clip = brickSounds[Random.Range(0, brickSounds.Length)];
        level.CountDestroyedBlock();
        localAudioSource.PlayOneShot(clip);
        Destroy(localSpriteRenderer);
        Destroy(localBoxCollider2D);
        Destroy(gameObject,2f);
    }
}
