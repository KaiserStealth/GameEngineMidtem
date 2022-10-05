using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text text;
    public int score;

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}
