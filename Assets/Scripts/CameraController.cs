using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject Unitychan;

    // Use this for initialization
    void Start()
    {
        // Playerの部分はカメラが追いかけたいオブジェクトの名前をいれる
        Unitychan = GameObject.Find("Unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = Unitychan.transform.position;
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);
    }
}