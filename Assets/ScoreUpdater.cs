using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // ScoreValue 文本组件的引用
    public TextMeshProUGUI reasonsText; // 用于显示原因的文本组件的引用

    // 在 Start 方法中初始化得分并更新 UI
    void Start()
    {
        // 获取 GameManager 的实例
        GameManager gameManager = GameManager.Instance;
        if (gameManager != null)
        {
            // 从 GameManager 中获取得分和原因列表
            int score = gameManager.GetScore();
            var reasons = gameManager.GetReasons();

            // 更新 UI
            UpdateScoreUI(score, reasons);
        }
        else
        {
            Debug.LogWarning("GameManager instance not found!");
        }
    }

    // 更新得分和原因UI
    public void UpdateScoreUI(int score, List<string> reasons)
    {
        // 将得分显示在 ScoreValue 文本组件中
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
        else
        {
            Debug.LogWarning("ScoreText is not assigned in ScoreUpdater script!");
        }

        // 将原因列表显示在 Reasons 文本组件中
        if (reasonsText != null)
        {
            // 清空原有文本内容
            reasonsText.text = "";

            // 将每个原因添加到文本中
            foreach (var reason in reasons)
            {
                reasonsText.text += reason + "\n";
            }
        }
        else
        {
            Debug.LogWarning("ReasonsText is not assigned in ScoreUpdater script!");
        }
    }
}
