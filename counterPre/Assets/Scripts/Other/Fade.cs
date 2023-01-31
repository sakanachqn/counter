using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    private string title = "TitleScene";
    private string game = "GameScene";
    private string res = "ResultScene";

    private CanvasGroup fadeGroup;

    public static Fade fade;

    public bool IsFadeOut = false;
    public bool StoG = false;
    public bool GtoR = false;
    public bool RtoS = false;
    public bool IsFadeIn = false;

    private bool IsChangeScene = false;

    private void Awake()
    {
        if(fade == null)
        {
            fade = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        fadeGroup = GetComponent<CanvasGroup>();
        fadeGroup.alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (RtoS) SceneChange(title, RtoS);
        if (GtoR) SceneChange(res, GtoR);
        if (StoG) SceneChange(game, StoG); 
    }

    void SceneChange(string scene, bool type)
    {
        FadeOut();
        if (IsChangeScene)
        {
            SceneManager.LoadScene(scene);
            IsChangeScene = false;
            IsFadeIn = true;
        }
        FadeIn(type);
    }

        void FadeIn(bool scenetype)
    {
        if(IsFadeIn)
        {
            fadeGroup.alpha -= Time.deltaTime;
            if(fadeGroup.alpha <= 0)
            {
                IsFadeIn = false;
                scenetype = false;
                Debug.Log(scenetype);
            }
        }
    }

    void FadeOut()
    {
        if (IsFadeOut)
        {
            fadeGroup.alpha += Time.deltaTime;
            if(fadeGroup.alpha >= 1)
            {
                IsFadeOut = false;
                IsChangeScene = true;
            }
        }
    }

    public void boolRes()
    {
        RtoS = false;
        GtoR = false;
        StoG = false;
    }
}
