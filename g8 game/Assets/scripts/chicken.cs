﻿
using UnityEngine;//引用Unity API

//類別 類別名稱
public class chicken : MonoBehaviour
{
    #region 欄位區域
    //宣告變數(定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱 指定 值 結束
    //私人 - 隱藏private (預設)
    //公開 - 顯示 public
    [Header("移動速度") ][Range(1,100)]
    public int speed = 10;          // 整數1, 9999, -100
    [Tooltip("G8雞的旋轉速度"),Range(1.5f,200f)]
    public float turn = 20.5f;      //浮點數
    public bool mission;            //布林值 true false
    public string _name = "G8 chicken";     // 字串 ""
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    

    private void Update()
    {
        Turn();
        Run();
    }
    #region 方法區域
    /// <summary>
    /// 跑步
    ///  </summary>
    private void Run()
    {
        //    rig.AddForce(0, 0, speed*v);
        float v = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward * speed * v);
    }

    ///<summary>
    ///旋轉
    ///</summary>
    private void Turn()
    {
        float h= Input.GetAxis("Horizontal");  //A左  -1.D 右1.沒按0
        
        tran.Rotate(0, turn*h, 0);
    }

    /// <summary>
    /// 亂跳
    /// </summary>
    private void Bark()
    {

    }

    ///<summary>
    ///撿東西
    ///</summary>
    private void Catch()
    {

    }

    ///<summary>
    ///檢視任務
    ///</summary>
    private void Task()
    {

    }
    #endregion
}

