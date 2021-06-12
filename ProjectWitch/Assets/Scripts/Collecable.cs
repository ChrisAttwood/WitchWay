using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecable : MonoBehaviour
{
    public AudioClip BonusSound;
    public GameObject PickUpEffect;
    int Score = 600;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(BonusSound, Camera.main.transform.position);
        GameManager.instance.AddScore(Score);
        var effect = Instantiate(PickUpEffect);
        effect.transform.position = transform.position;
        Destroy(gameObject);
    }
}
