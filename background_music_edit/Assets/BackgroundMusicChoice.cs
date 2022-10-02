using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicChoice : MonoBehaviour
{

    public AudioSource choice_1;
    public AudioSource choice_2;
    public AudioSource choice_3;

    // Start is called before the first frame update
    void Start()
    {
        choice_1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            if (choice_1.isPlaying) {
                Debug.Log("playing choice_2");
                choice_1.Stop();
                choice_2.Play();
            } else if (choice_2.isPlaying) {
                Debug.Log("playing choice_1");
                choice_2.Stop();
                choice_1.Play();
            }
        }
    }
}
