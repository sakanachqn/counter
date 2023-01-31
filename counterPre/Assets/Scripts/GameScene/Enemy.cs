using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyAtkEffect; //攻撃エフェクトのプレハブ
    [SerializeField]
    private GameObject EffectArea;  //描写用のキャンバス取得

    private GameObject setEffect;   //一次保存用変数

    private float attackRhythm;
    private float attackCD;

    // Start is called before the first frame update
    void Start()
    {
        attackRhythm = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.IsStartGame)
        {
            attackCD += Time.deltaTime;
            if (attackCD >= attackRhythm)
            {
                StartCoroutine(AttackMove());
                attackCD = 0;
                attackRhythm = Random.Range(1, 3);
            }
        }
    }

    /// <summary>
    /// 敵の攻撃コルーチン
    /// </summary>
    /// <returns></returns>
    private IEnumerator AttackMove()
    {
        this.transform.Find("EnemyNeutral").gameObject.SetActive(false);
        this.transform.Find("EnemyAttack").gameObject.SetActive(true);
        StartCoroutine(EffectCreate());
        yield return new WaitForSeconds(0.5f);
        this.transform.Find("EnemyAttack").gameObject.SetActive(false);
        this.transform.Find("EnemyNeutral").gameObject.SetActive(true);
    }

    /// <summary>
    /// 攻撃回数
    /// </summary>
    /// <returns></returns>
    private IEnumerator EffectCreate()
    {
        int rnd = Random.Range(1, 6);
        for(int i = 0; i < rnd; i++)
        {
            setEffect = Instantiate(EnemyAtkEffect, EffectArea.transform, false);
            yield return new WaitForSeconds(0.2f);
        }
    }

    
}
