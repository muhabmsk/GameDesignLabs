using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioManager instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioClip overworldMusic;
    public AudioClip caveMusic;
    public AudioClip[] variousSFX;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        musicSource.clip = overworldMusic;
        musicSource.Play();
    }
public void PlayMusicSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    public void PlayRandomSFX(params AudioClip[] clips)
    {
        variousSFX = clips;

        int index = Random.Range(0, variousSFX.Length);
        sfxSource.PlayOneShot(variousSFX[index]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
