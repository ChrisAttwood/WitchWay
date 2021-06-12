using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecable : MonoBehaviour
{
    public AudioClip BonusSound;
    int Score = 600;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(BonusSound, transform.position);
        GameManager.instance.AddScore(Score);
        Destroy(gameObject);
    }
}
