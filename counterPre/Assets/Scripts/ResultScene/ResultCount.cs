using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultCount : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI resCount;

    public static int Parrycount = 0;

    // Start is called before the first frame update
    void Start()
    {
        resCount.text = Parrycount.ToString() + "��e�����I";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
