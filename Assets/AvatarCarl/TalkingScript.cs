using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingScript : MonoBehaviour
{

    public Animator CarlsBody;
    public AudioSource objectSource;
    public AudioClip whatToDoClip;

    // Start is called before the first frame update
    void Start()
    {
        objectSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) {
            Talk();
        }
    }

    void Talk() {
        StartCoroutine(Timer());
    }

    IEnumerator Timer() {
        CarlsBody.SetBool("Audio", true);
        objectSource.PlayOneShot(whatToDoClip, 0.8f);
        yield return new WaitForSeconds(whatToDoClip.length);
        CarlsBody.SetBool("Audio", false);
    }






}
