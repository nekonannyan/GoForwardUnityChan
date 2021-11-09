using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    //オブジェクトに当たったら実行する
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //オブジェクトの名前がブロックかgroundならば音を鳴らす
        if (collision.gameObject.name == this.name
        ||  collision.gameObject.name == "ground")
        {
            GetComponent<AudioSource>().Play();
        }  
    }
}
