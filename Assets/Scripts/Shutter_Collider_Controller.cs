using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutter_Collider_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 def = new Vector3(0,0,0); // 最初の座標
    float height = 0; // 高さ
    void Start()
    {
        def = this.transform.position;
        height = this.transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        float rose = this.transform.position.y - def.y; //上がった分

        BoxCollider b = this.gameObject.GetComponent<BoxCollider>(); // collider取得
        b.size = new Vector3(1,1.0f - rose / height,1); // rose / heightで上がった割合を計算
        b.center = new Vector3(0,rose / height / -2,0);
    }
}
