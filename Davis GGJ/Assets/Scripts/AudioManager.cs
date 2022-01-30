using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //fuck it, singleton
    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    private AudioSource source;

    public OctaveSet[] RiffClips;
    [System.Serializable]
    public struct OctaveSet
    {
        //Riff clips
        public AudioClip[] AudioClips;
    }

    public void PlayLHClipOneShot(int index,int octave)
    {
        source.PlayOneShot(RiffClips[octave+1].AudioClips[index]);
    }
}
