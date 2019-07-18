using UnityEngine;

public class Enemy1Script : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public GameObject explosion;
    public int speed = -3;
    public int attackPoint = 10;
    public LifeScript lifeScript;
    int count; // 無敵時間のカウンタ
    bool isHit; // ヒットしたかのフラグ　障害物と当たったらtrueになる

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
        if (count > 0)
        {
            --count;
            if (count <= 0)
            {
                // 無敵時間の終わり
                count = 0;
                isHit = false;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //UnityChanとぶつかった時
        if (col.gameObject.tag == "UnityChan" && isHit == false && count == 0)
        {
            //LifeScriptのLifeDownメソッドを実行
            lifeScript.LifeDown(attackPoint);
            count = 30; // 無敵時間をセット
        }
    }
}