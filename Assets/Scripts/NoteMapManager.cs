using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NoteMapManager : MonoBehaviour
{
    public float noteSpeed;
    public bool gameHasStarted = false;
    public float delayTimer;
    public AudioSource Song;

    void StartGame()
    {
        gameHasStarted = true;
        Song.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 60;
        delayTimer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        while (gameHasStarted == false)
        {

            delayTimer -= Time.deltaTime;
        }

        if (delayTimer <= 0)
        {
            StartGame();
        }

        if (gameHasStarted)
        {

            transform.position += new Vector3(0, 0, noteSpeed);
        }

    }
}
