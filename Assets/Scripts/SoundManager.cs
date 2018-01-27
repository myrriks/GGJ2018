﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Smf;
using Melanchall.DryWetMidi.Smf.Interaction;
using System;
using System.Linq;

public class SoundManager : MonoBehaviour
{
    MidiFile f;
    AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        f = MidiFile.Read(Application.dataPath + "/Midi/" + "tetris_midi.mid");
        audioSource = GetComponent<AudioSource>();
        if (audioSource.isPlaying)
            audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var v in f.GetNotes())
        Debug.Log(v.NoteNumber);
    }
}
