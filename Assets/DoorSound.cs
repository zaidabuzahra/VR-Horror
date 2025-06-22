using UnityEngine;

public class DoorSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip openSound;

    // This method name must match the one set in the animation event
    public void PlayOpenSound()
    {
        if (audioSource && openSound)
        {
            audioSource.PlayOneShot(openSound);
        }
    }
}
