using UnityEngine;

public class BulletScript : MonoBehaviour
{

    private GameObject player;
    private readonly int speed = 10;
    

    void Start()
    {
        //ユニティちゃんオブジェクトを取得
        player = GameObject.FindWithTag("UnityChan");
        //rigidbody2Dコンポーネントを取得
#pragma warning disable RECS0117 // ローカル変数の名前がメンバーと同じであるため、メンバーが表示されません
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
#pragma warning restore RECS0117 // ローカル変数の名前がメンバーと同じであるため、メンバーが表示されません
                                //ユニティちゃんの向いている向きに弾を飛ばす
        rigidbody2D.velocity = new Vector2(speed * player.transform.localScale.x, rigidbody2D.velocity.y);
        //画像の向きをユニティちゃんに合わせる
        Vector2 temp = transform.localScale;
        temp.x = player.transform.localScale.x;
        transform.localScale = temp;
        //5秒後に消滅
        Destroy(gameObject, 5);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}