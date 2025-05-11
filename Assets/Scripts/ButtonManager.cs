using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Button;
    public string buttontype;


    void Start()
    {
        Button = GameObject.FindGameObjectWithTag(buttontype);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(buttontype == "Re")
        {

            SceneManager.LoadScene(1);
        }

        if (buttontype == "Start")
        {           
            //  SceneManager.LoadScene(1);
             SceneManager.LoadScene("StartMenu");

        }
    }
}
