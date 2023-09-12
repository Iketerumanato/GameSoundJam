using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    [SerializeField] float fadeSpeed = 0.01f; //透明度が変わるスピードを管理
    float red, green, blue, alfa; //パネルの色、不透明度を管理

    public bool isFadeOut = false; //フェードアウト処理の開始、完了を管理するフラグ

    Image fadeImage; //透明度を変更するパネルのイメージ

    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    void Update()
    {
        if (isFadeOut)
        {
            StartFadeOut();
        }
    }

    //シーンを移動したい時はこっち
    void StartFadeOut()
    {
        fadeImage.enabled = true; 
        alfa += fadeSpeed;
        SetAlpha();
        if (alfa >= 1f)
        {
            isFadeOut = false;
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}