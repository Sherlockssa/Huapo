using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPanelController : MonoBehaviour
{
    // 选关按钮点击事件
    public void LevelSelectButtonClicked()
    {
        UIManager.Instance.InteractTip.gameObject.SetActive(false);
        UIManager.Instance.Catalog.SetActive(true);
        gameObject.SetActive(false);
        CanvasScoreController scoreController = FindObjectOfType<CanvasScoreController>();
        if (scoreController != null)
        {
            scoreController.CloseCanvasScore();
        }
        else
        {
            Debug.LogWarning("CanvasScoreController not found!");
        }
    }

    // 退出按钮点击事件
    public void QuitButtonClicked()
    {
        // 在这里添加退出游戏的逻辑
        // 可以根据需要调用 GameManager 中的 Quit 方法
        GameManager.Instance.Quit();
    }
}
