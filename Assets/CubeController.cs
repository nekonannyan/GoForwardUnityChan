using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    //�I�u�W�F�N�g�ɓ�����������s����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�I�u�W�F�N�g�̖��O���u���b�N��ground�Ȃ�Ή���炷
        if (collision.gameObject.name == this.name
        ||  collision.gameObject.name == "ground")
        {
            GetComponent<AudioSource>().Play();
        }  
    }
}
