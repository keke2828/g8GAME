using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{

    //靜態
    //隨機.數學.輸入.時間
    private void Start()
    {
        //使用靜態屬性
        //類別名稱.靜態屬性
        //取得靜態屬性
        print(Random.value);   //0-1
        print(Mathf.PI);

        //類別名稱.靜態方法(對應引數)
        print(Mathf.Abs(-99));
        print(Random.Range(50, 150));

        Debug.Log("測試~");
        Debug.LogWarning("警告!");
        Debug.LogError("危險!");
    }

    //更新事件:一秒直行約60次
    //監聽玩家輸入事件.時間
    private void Update()
    {
        print(Time.time);

        //輸入.靜態屬性-滑鼠座標(0.0)vector3
        //print(Input.mousePosition);
        //輸入.靜態方法-玩家是否按下空白建-傳回布林直方法
        //按下空白建會顯示turn
        //按下空白建會顯示false
        print(Input.GetKeyDown(KeyCode.Space));// 列舉enum
    }

}
