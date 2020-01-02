using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LrearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    private int C = 1;
    private int D = 1, E = 1;
    private int F = 10;

    public float G = 1.5f, H = 99.9f;

    public float hp =  50;

    public bool key;
    public int enemy;



    private void Start()
    {
        #region 數學運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        //指派有邊先運行再給左邊
        C = 99 + 1;
        print(C);
        C = C + 1;

        print(D++);
        print(++E);


        F +=100;
        print(F);
        #endregion

        #region 比較運算子
        print(G > H);
        print(G < H);
        print(G >= H);
        print(G <= H);
        print(G == H);
        print(G != H);
        #endregion

        #region 邏輯運算子

        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);


        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        print(!true);
        print(!false);

        #endregion


    }

    private void Update()
    {
        print("死亡:" + (hp < -0));
        print("過期:" + (key || enemy >= 5));
    }
}
