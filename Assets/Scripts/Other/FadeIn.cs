using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] float fadeSpeed = 0.01f; //透明度が変わるスピードを管理
    float red, green, blue, alfa; //パネルの色、不透明度を管理

    public bool isFadeIn = false;//フェードイン処理の開始、完了を管理するフラグ

    Image fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn)
        {
            StartFadeIn();
        }
    }

    void StartFadeIn()
    {
        alfa -= fadeSpeed;               
        SetAlpha();                     
        if (alfa <= 0f)
        {                                            
            isFadeIn = false;
            fadeImage.enabled = false;
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
