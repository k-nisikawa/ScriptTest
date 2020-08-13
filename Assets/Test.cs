using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // magicの関数
    public void Magic(int cm)
    {
        if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            mp = mp - cm;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }

    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //課題ここから★★★
        Debug.Log("課題");
        // 要素数5の配列を初期化する
        int[] array = {1, 2, 3, 4, 5 };

        Debug.Log("表示");
        // 配列の要素を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        // 配列の要素を逆順番に表示する
        Debug.Log("逆表示");
        for (int a = 4; a > -1; a-- )
        {
            Debug.Log(array[a]);
        }
        //課題ここまで★★★

        //発展課題ここから★★★
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();

        // 魔法攻撃用の関数を呼び出す
        for (int im = 0; im <= 10; im++)
        {
        lastboss.Magic(5);
        }

        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //発展課題ここまで★★★
    }

    // Update is called once per frame
    void Update()
    {

    }
}