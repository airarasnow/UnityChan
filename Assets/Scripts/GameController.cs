using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject winnerLabelObject;
    float TimeCount = 5;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (count == 0)
        {
            // オブジェクトをアクティブにする
            winnerLabelObject.SetActive(true);
            //ゲームシーンを切り替え
            TimeCount -= Time.deltaTime;
            if (TimeCount <= 0)
            {
                SceneManager.LoadScene("GameScene2");
            }
        }
    }
}
