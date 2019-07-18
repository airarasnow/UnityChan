using UnityEngine;

public class RockController : MonoBehaviour
{

    float fallSpeed;
    float rotSpeed;
    public int attackPoint = 10;
    public LifeScript lifeScript;

    void Start()
    {
        fallSpeed = 0.01f + 0.1f * Random.value;
        rotSpeed = 5f + 3f * Random.value;
    }

    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "UnityChan")
        {
            lifeScript.LifeDown(attackPoint);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UnityChan")
        {
            lifeScript.LifeDown(attackPoint);
        }
    }
}