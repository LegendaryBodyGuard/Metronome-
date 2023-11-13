using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;


public class Metronome : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip metronomeSound;
    
    [SerializeField] private TextMeshProUGUI playButtonText;
    [SerializeField] private TextMeshProUGUI tempoText;
    [SerializeField] private int tempo = 60;
    
    public float beatDuration;
    public float timer;
    public float newtimer;
    
    private bool isStarted = false;
    private bool isPlaying = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Audio = GetComponent<AudioSource>();
        Audio.clip = metronomeSound;
        
        beatDuration = 60.0f / tempo;
        timer = beatDuration;
        tempoText.SetText(tempo+"");
        
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        {
            timer -= Time.deltaTime;

            if (timer <= 0.0f)
            {
                // Play the metronome sound
                Audio.Play();

                // Reset the timer for the next beat
                timer = beatDuration;
            }
        }
    }

    public void soundToggle()
    {
        if (isPlaying)
        {
            if (Audio.isPlaying)
            {
                Audio.Stop();
            }
            playButtonText.text = "Play";
            isStarted = false; // Add this line to stop the metronome
        }
        else
        {
            if (!Audio.isPlaying)
            {
                Audio.Play();
            }
            playButtonText.text = "Stop";
            isStarted = true; // Start the metronome when the button is pressed
        }

        isPlaying = !isPlaying;
    }
    
    public void increaseTempo()
    {
        tempo += 1;
        tempoText.SetText(tempo+"");
        beatDuration = 60.0f / tempo;
        timer = beatDuration;
    }
    
    public void decreaseTempo()
    { 
        tempo -= 1;
        tempoText.SetText(tempo+"");
        beatDuration = 60.0f / tempo;
        timer = beatDuration;
        // tempoText.text = tempo;
    }
}
