using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
    public UIController uiController;
    AudioSource audioSource;
    public AudioClip pain;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!uiController.timerIsRunning) {
            UnityEngine.Debug.Log("Time's up, you've died!!");
            SceneManager.LoadScene("Level1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7){
            audioSource.clip = pain;
            audioSource.enabled = true;
            audioSource.Play();

            UnityEngine.Debug.Log("You've died!!");
            Invoke("loadScene", 0.6f);
            Rigidbody rat_rb = GetComponent<Rigidbody>();
            rat_rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    private void loadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
