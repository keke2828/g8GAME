
using UnityEngine;//引用Unity API

//類別 類別名稱
public class chicken : MonoBehaviour
{
    #region 欄位區域
    //宣告變數(定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱 指定 值 結束
    //私人 - 隱藏private (預設)
    //公開 - 顯示 public
    [Header("移動速度")] [Range(1, 100)]
    public int speed = 10;          // 整數1, 9999, -100
    [Tooltip("G8雞的旋轉速度"), Range(1.5f, 200f)]
    public float turn = 20.5f;      //浮點數
    public bool mission;            //布林值 true false
    public string _name = "G8 chicken";     // 字串 ""
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    public AudioSource aud;

    public AudioClip soundBark;

    [Header("檢物品位置")]
    public Rigidbody rigCatch;

    private void Update()
    {
        Turn();
        Run();
        Catch();
    }
    //觸發碰撞時持續執行(一秒執行約60次)碰撞物件資訊
    private void OnTriggerStay(Collider other)
    {
        print(other.name);

        //如果 碰撞物件的名稱 為 漢堡
        if (other.name == "漢堡")
        {
            Physics.IgnoreCollision(other, GetComponent<Collider>());
            //碰撞物件.取得元件<泛型>().連接身體 = 檢物品位置
            other.GetComponent<HingeJoint>().connectedBody = rigCatch;
        }

        if (other.name == "沙子")
        {
           
            GameObject.Find("漢堡").GetComponent<HingeJoint>().connectedBody = null;
        }
    }


    #region 方法區域
    /// <summary>
    /// 跑步
    ///  </summary>
    private void Run()
    {
        //如果 動畫 為 撿東西 就 跳出
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("撿東西")) return;

        float v = Input.GetAxis("Vertical");
       // rig.AddForce(0, 0, speed * v);  //世界座標
        //tran.forward 區域座標z軸
        //tran.right   區域座標x軸
        //tran.up      區域座標y軸
        rig.AddForce(tran.forward * speed * v );

        ani.SetBool("走路開關", v != 0);

    }
        ///<summary>
        ///旋轉
        ///</summary>
      private void Turn()
    {
        float h= Input.GetAxis("Horizontal");  //A左  -1.D 右1.沒按0
        
        tran.Rotate(0, turn*h, 0);
    }



        ///<summary>
        ///劈腿撿東西
        ///</summary>
        private void Catch()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            //按下左鍵撿東西
            ani.SetTrigger("劈腿撿東西");

            aud.PlayOneShot(soundBark,0.2f);
        }
       
    }

        ///<summary>
        ///檢視任務
        ///</summary>
         private void Task()
    {

    }
    #endregion
}

