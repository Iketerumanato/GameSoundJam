using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    [SerializeField] float fadeSpeed = 0.01f; //�����x���ς��X�s�[�h���Ǘ�
    float red, green, blue, alfa; //�p�l���̐F�A�s�����x���Ǘ�

    public bool isFadeOut = false; //�t�F�[�h�A�E�g�����̊J�n�A�������Ǘ�����t���O

    Image fadeImage; //�����x��ύX����p�l���̃C���[�W

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

    //�V�[�����ړ����������͂�����
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