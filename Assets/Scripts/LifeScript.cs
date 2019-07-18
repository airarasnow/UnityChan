﻿using UnityEngine;

public class LifeScript : MonoBehaviour
{

    RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    public void LifeDown(int ap)
    {
        //RectTransformのサイズを取得し、マイナスする
        rt.sizeDelta -= new Vector2(0, ap);
    }
}