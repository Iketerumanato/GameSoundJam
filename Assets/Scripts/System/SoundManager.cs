using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] GameSE;
    AudioSource GameSound;

    public void PlayerSettings()
    {
        GameSound.PlayOneShot(GameSE[0]);
    }
}
