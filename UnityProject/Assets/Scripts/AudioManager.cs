using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip[] soundsList;
    private static List<AudioClip> audioList;

    void Start()
    {
        instance = this;
        audioList = new List<AudioClip>();
        for (int i = 0; i < soundsList.Length; i++)
        {
            audioList.Add(soundsList[i]);
        }
    }

    public static void PlaySound(int soundNumber)
    {
        instance.gameObject.GetComponent<AudioSource>().PlayOneShot(audioList[soundNumber]);
    }
}
