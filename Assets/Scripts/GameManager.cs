using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text currentBlockNumberText;
    private int currentBlockNumber;
    // Start is called before the first frame update
    void Start()
    {
        currentBlockNumber = GameObject.FindGameObjectsWithTag("Block").Length;
        ViewCurrentBlockNumber();
    }

    void ViewCurrentBlockNumber(){
        currentBlockNumberText.text = $"残り：{currentBlockNumber}";
    }

    public void DestroyBlockObject(){
        currentBlockNumber--;
        ViewCurrentBlockNumber();
    }
}
