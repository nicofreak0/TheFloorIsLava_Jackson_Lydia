using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip bump;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip water;
    [SerializeField] AudioClip hit;
    [SerializeField] AudioClip wood;
    [SerializeField] AudioClip chains;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Paddle")
        {
            audio.PlayOneShot(bump);
        }
        if (collision.gameObject.tag == "domino")
        {
            audio.PlayOneShot(crash);
        }
        if (collision.gameObject.tag == "ramp")
        {
            audio.PlayOneShot(hit);
        }
        if (collision.gameObject.tag == "water")
        {
            audio.PlayOneShot(water);
        }
        if (collision.gameObject.tag == "creaking wood")
        {
            audio.PlayOneShot(wood);
        }
        if (collision.gameObject.tag == "chains")
        {
            audio.PlayOneShot(chains);
        }
    }
}