using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextHidden : MonoBehaviour
{
    //[SerializeField] int openTime = 95;
    float openTime;
    float musicTime;

    // Start is called before the first frame update
    void Start()
    {
        musicTime = Title.musicTime;

        //オブジェクトを非アクティブにする
        this.gameObject.SetActive(true);
        //曲終了後にOpen関数を実行する
        Invoke("Open", openTime);
    }

    //
    void Open()
    {
        //オブジェクトをアクティブにする
        this.gameObject.SetActive(false);
    }
}