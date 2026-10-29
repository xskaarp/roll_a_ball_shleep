using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioSource soundFXObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySoundFXClip(AudioClip audioclip, Transform _spawnTransform, float volume)
    {
       
        // spawn in gameObject
        AudioSource audioSource = Instantiate(soundFXObject, _spawnTransform.position, Quaternion.identity);

        //assign the audioClip
        audioSource.clip = audioclip;

        //assign volume
        audioSource.volume = volume;

        //play the sound
        audioSource.Play();

        //lenght of sound FX clip
        float _cliplenght = audioSource.clip.length;

        // destroy the clip after it is done playing
        Destroy(audioSource.gameObject, _cliplenght);
    }
}
