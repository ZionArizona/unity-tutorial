using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI��� ���̺귯��
using TMPro;

public class GameManagerLogic : MonoBehaviour
{
    public int TotalItemCount;
    public int stage = 0;
    public TextMeshProUGUI stageCountText;
    public TextMeshProUGUI playerCountText;
    void Awake()
    {
        stageCountText.text = "/" + TotalItemCount.ToString();
    }
    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }
}
