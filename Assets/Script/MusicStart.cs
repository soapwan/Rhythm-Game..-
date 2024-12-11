using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip OhMyGirl;
    public float songBpm;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float dspSongTime;
    
    /*void Start()
    {
        AS.clip = OhMyGirl;
        AS.Play();
            
    }*/
    
    void Start()
    {
        songBpm = 126;
            
        AS.clip = OhMyGirl;
        //Load the AudioSource attached to the Conductor GameObject
        //OhMyGirl = GetComponent<AudioClip>();
    
        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;
    
        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;
    
        //Start the music
        AS.Play();
    }

    void Update()
    {
        //determine how many seconds since the song started
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
    
        //determine how many beats since the song started
        songPositionInBeats = songPosition / secPerBeat;
    }
}
