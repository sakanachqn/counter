using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI GoText;

    // Start is called before the first frame update
    void Start()
    {
        ResultCount.Parrycount = 0;
        StartCoroutine(StartText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator StartText()
    {
        GoText.text = "よーい";
        yield return new WaitForSeconds(1);
        GoText.text = "初め！";
        yield return new WaitForSeconds(0.5f);
        GoText.text = null;
        Player.IsStartGame = true;
    }
    
}
