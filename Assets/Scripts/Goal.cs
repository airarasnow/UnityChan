using UnityEngine;

public class Goal : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //UnityChanとぶつかった時
        if (col.gameObject.tag == "UnityChan")
        {
            col.gameObject.transform.SetParent(this.transform);
            Rigidbody2D rb = col.gameObject.GetComponent<Rigidbody2D>();
            rb.simulated = false;
            Player p = col.gameObject.GetComponent<Player>();
            p.enabled = false;
            rigidbody2D.AddForce(Vector2.up * 50f);
        }
    }
}
