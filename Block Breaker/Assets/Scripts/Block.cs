using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    // config
    [SerializeField] AudioClip[] brickSounds;
    [SerializeField] ParticleSystem particlesVFX;
    Level level;

    // components
    AudioSource localAudioSource;
    SpriteRenderer localSpriteRenderer;
    BoxCollider2D localBoxCollider2D;
    GameController game;
    

    private void Start()
    {
        localAudioSource = GetComponent<AudioSource>();
        localSpriteRenderer = GetComponent<SpriteRenderer>();
        localBoxCollider2D = GetComponent<BoxCollider2D>();
        level = FindObjectOfType<Level>();
        game = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BlockDestruction();
    }

    void BlockDestruction() {
        ParticleSystem currentParticles = Instantiate(particlesVFX, transform.position, transform.rotation);
        currentParticles.startColor = GetComponent<SpriteRenderer>().color;
        Destroy(currentParticles, 2);

        AudioClip clip = brickSounds[Random.Range(0, brickSounds.Length)];
        level.CountDestroyedBlock();
        game.IncreaseScore();
        localAudioSource.PlayOneShot(clip);
        Destroy(localSpriteRenderer);
        Destroy(localBoxCollider2D);
        Destroy(gameObject, 2f);
    }
}
