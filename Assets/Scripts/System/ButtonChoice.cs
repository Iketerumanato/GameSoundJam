using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoice : MonoBehaviour
{
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Canvas/ButtonSummary/TitleButton").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();
    }
}
