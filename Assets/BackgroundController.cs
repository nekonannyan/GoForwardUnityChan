using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // �X�N���[�����x
    private float scrollSpeed = -1;
    // �w�i�I���ʒu
    private float deadLine = -18;
    // �w�i�J�n�ʒu
    private float startLine = 17.8f;

    void Update()
    {
        // �w�i���ړ�����
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);
        // ��ʊO�ɏo����A��ʉE�[�Ɉړ�����
        if (transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
    }
}