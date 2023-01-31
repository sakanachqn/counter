using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    [SerializeField]
    AudioClip parrySE;

    AudioSource audioSource;

    public static PlaySE instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayParrySE()
    {
        audioSource.PlayOneShot(parrySE);
    }
}
