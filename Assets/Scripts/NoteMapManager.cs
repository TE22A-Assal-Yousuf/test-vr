using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEditor;
using UnityEngine.UI;

public class NoteMapManager : MonoBehaviour
{

    public GameObject endGameScreen;

    public GameObject restartButton;
    //------------------------------------------------

    public float startDistance = 0.948f;
    public float delayDistance;
    public float delayTimer;
    public Vector3 trueNoteSpeed;
    public float noteSpeed;
    public float songNoteSpeed = 0.054f;
    public float delayNoteSpeed;
    public float noteDistance = 0.54f;
    float notesPerSecond = 2.16f;
    public TextMeshProUGUI displayTimer;
    public TMP_Text gameEnddisplay;
    float timer = 60;
    bool gameHasEnded = false;


    //--------------------------------------------------
    public bool gameHasStarted = false;
    public int songplayedamount;
    public AudioSource Song;
    public AudioClip clip;
    public float volume = 0.1f;

    public void StartGame()
    {
        gameHasStarted = true;
        noteSpeed = songNoteSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        Song.PlayOneShot(clip, volume);

        Player.currentAcuracy = 100;

        //-----------------------------------------------------------------------------------------

        restartButton.SetActive(false);
        endGameScreen.SetActive(false);
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        // Application.targetFrameRate = 0;

        //-------------------------------------------------------------------------------------

        delayTimer = 7.5f;      

        delayDistance = -14;

        delayNoteSpeed = delayDistance / delayTimer *-1 * 0.04f * 0.5f ;
        
        transform.position = new Vector3(-0.882f, 0.948f, delayDistance);
        
        noteSpeed = delayNoteSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        displayTimer.text = $"{(int)timer}";

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
            trueNoteSpeed = new Vector3(0, 0, noteSpeed);
            transform.localPosition += trueNoteSpeed * Time.deltaTime * 58;
            timer -= Time.deltaTime;
        }
        else if(gameHasStarted == false)
        {
            trueNoteSpeed = new Vector3(0, 0, noteSpeed);
            transform.localPosition += trueNoteSpeed * Time.deltaTime * 58;
            transform.position += new Vector3(0 ,0 , noteSpeed * Time.deltaTime);
        }

        if(timer <= 0)
        {
            Time.timeScale = 1; 
            Song.Stop();  
            gameHasEnded = true;      
        }

        if(gameHasEnded)
        {
            restartButton.SetActive(true);
            endGameScreen.SetActive(true);
            gameEnddisplay.text = $" you had a {Player.DisplayAccuracy}% Accuracy";
        }

    }
}
