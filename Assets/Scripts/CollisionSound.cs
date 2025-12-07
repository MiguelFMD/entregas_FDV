using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    private AudioSource playerSource;
    public AudioClip collisionClip;

    void Start()
    {
        playerSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        float impactForce = collision.relativeVelocity.magnitude;

        playerSource.PlayOneShot(collisionClip, Mathf.Clamp01(impactForce / 2f));
    }
}