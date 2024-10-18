using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public TextMeshProUGUI display;
    // Start is called before the first frame update

    public static float currentAcuracy = 100;
    public float DisplayAccuracy;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAccuracy = currentAcuracy;
        
        display.text = $"Accuracy {(int)DisplayAccuracy}%";
    }
}
