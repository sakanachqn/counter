using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCreate : MonoBehaviour
{
    [SerializeField]
    private GameObject FadeCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(FadeCanvas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
