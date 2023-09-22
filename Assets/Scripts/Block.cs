using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public int number;

    private void Awake()
    {
        textMesh.text = number.ToString();
    }

    public void SetText(int num)
    {
        number = num;

        textMesh.text = number.ToString();

        if (number >= GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].completedLevelCondition)
        {
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].isCompleted = true;
            GameManager.Instance.CheckLevelUp();
        }
    }
}
