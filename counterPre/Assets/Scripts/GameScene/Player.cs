using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerAttackEffect;  //プレイヤー攻撃のプレハブ
    [SerializeField]
    private GameObject EffectArea;  //描写用キャンバス
    [SerializeField]
    private TextMeshProUGUI EndText;

    private GameObject setEffect;
    private bool IsCD = false;
    private bool IsGameOver = false;

    public static bool IsStartGame = false;

    private int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsStartGame)StartCoroutine(PlayerAtk());
        if(0 == HP) IsGameOver = true;
        if(IsGameOver)StartCoroutine(endGame());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        HP--;
    }

    private IEnumerator PlayerAtk()
    {
        if(Input.GetKeyDown(KeyCode.F) && !IsCD)
        {
            IsCD = true;
            setEffect = Instantiate(PlayerAttackEffect, EffectArea.transform, false);
            yield return new WaitForSeconds(0.1f);
            Destroy(setEffect.gameObject);
            IsCD = false;
        }
    }

    private IEnumerator endGame()
    {
        IsStartGame = false;
        EndText.text = "止め！";
        yield return new WaitForSeconds(2);
        Fade.fade.boolRes();
        Fade.fade.GtoR = true;
        Fade.fade.IsFadeOut = true;
    }
}
