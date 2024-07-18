using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public TextMeshProUGUI pointText;
    public int Point {get; private set;}

    private void Start() {
        Instance = this;
        Point = 0;
        pointText.text = $"Points: {Point}";
    }

    public void AddPoint()
    {
        Point++;
        pointText.text = $"Points: {Point}";
    }
}

