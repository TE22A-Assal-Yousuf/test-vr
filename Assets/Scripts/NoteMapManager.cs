using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NoteMapManager : MonoBehaviour
{
    //------------------------------------------------

    public float startDistance = 0.948f;
    public float delayDistance;
    public float delayTimer;
    public float noteSpeed;
    public float songNoteSpeed = 0.052f;
    public float delayNoteSpeed;
    public float noteDistance = 0.54f;
    float notesPerSecond = 2.16f;


    //--------------------------------------------------
    public bool gameHasStarted = false;
    public int songplayedamount;
    public AudioSource Song;
    public AudioClip clip;
    public float volume = 0.1f;

    public void StartGame()
    {
        gameHasStarted = true;
        Song.PlayOneShot(clip, volume);
        noteSpeed = songNoteSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 60;

        //-------------------------------------------------------------------------------------

        delayTimer = 7;

        delayDistance = -14;

        delayNoteSpeed = delayDistance / delayTimer *-1 * 0.04f * 0.5f ;
        
        transform.position = new Vector3(-0.882f, 0.948f, delayDistance);
        
        noteSpeed = delayNoteSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (delayTimer > 0)
        {
            delayTimer -= Time.deltaTime;

        }
        
        if(delayTimer <= 1 && songplayedamount < 1)
        {
            StartGame();
            songplayedamount += 1;
        }

        if (gameHasStarted)
        {
            transform.position += new Vector3(0, 0, noteSpeed);
        }
        else if(gameHasStarted == false)
        {
            transform.position += new Vector3(0, 0, noteSpeed);
        }

    }
}
