using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScoreController : MonoBehaviour
{
    public GameObject canvasScore; // CanvasScore 游戏对象的引用

    // 在 Start 方法中禁用 CanvasScore
    private void Start()
    {
        if (canvasScore != null)
        {
            canvasScore.SetActive(false);
        }
    }

    // 打开 CanvasScore
    public void OpenCanvasScore()
    {
        if (canvasScore != null)
        {
            Debug.Log("Open");
            canvasScore.SetActive(true);
        }
    }

    // 关闭 CanvasScore
    public void CloseCanvasScore()
    {
        if (canvasScore != null)
        {
            canvasScore.SetActive(false);
        }
    }
}
