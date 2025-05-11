using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public TextMeshProUGUI display;

    public AudioSource hitSFX;
    public AudioClip clip;
    public float volume = 1f;
    
    // Start is called before the first frame update

    public static float currentAcuracy = 100;
    static public float DisplayAccuracy;

    void Start()
    {
        
    }

    void playsound()
    {

        hitSFX.PlayOneShot(clip, volume);
    }

    // Update is called once per frame
    void Update()
    {
        
        DisplayAccuracy = currentAcuracy;
        
        if(DisplayAccuracy <= 0 )
        {
            DisplayAccuracy = 0;
        }

        display.text = $"Accuracy {(int)DisplayAccuracy}%";
    }
}
