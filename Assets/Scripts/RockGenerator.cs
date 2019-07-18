using UnityEngine;

public class RockGenerator : MonoBehaviour
{

    public GameObject rockPrefab;
    Vector2 tmp;

    void Start()
    {
        InvokeRepeating("GenRock", 1, 1);
    }

    void GenRock()
    {
        tmp = GameObject.Find("Unitychan").transform.position;
        Instantiate(rockPrefab, new Vector2(-2.5f + tmp.x * Random.value, 6), Quaternion.identity);

    }
}