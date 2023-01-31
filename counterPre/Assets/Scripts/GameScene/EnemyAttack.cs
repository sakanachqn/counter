using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    [Tooltip("���ł���G�t�F�N�g�̑����̎w��")]
    private float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEff();
    }

    /// <summary>
    /// �G�̍U���̈ړ�
    /// </summary>
    void MoveEff()
    {
        Vector2 pos = this.GetComponent<RectTransform>().anchoredPosition;
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x - speed * (Time.deltaTime * 100), pos.y);
    }


}
