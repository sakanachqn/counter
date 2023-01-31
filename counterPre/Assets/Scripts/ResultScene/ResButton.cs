using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResButton : MonoBehaviour
{
    private bool IsClick = false;
    // Start is called before the first frame update
    void Start()
    {
        IsClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(!IsClick)
        {
            IsClick = true;
            Fade.fade.boolRes();
            Fade.fade.RtoS = true;
            Fade.fade.IsFadeOut = true;
        }
    }
}
