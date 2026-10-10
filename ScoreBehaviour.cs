//using System.Diagnostics;
using UnityEngine;
using TMPro;

public class CounterBehaviour : MonoBehaviour
{
    public TextMeshProUGUI scoreElement;

    private int counterValue = 0;

    public void Increment()
    {
        this.counterValue += GameManager.instance.increment;
        GameManager.instance.currentAmountOfPoints = this.counterValue;
    }

    private void Update()
    {
        this.scoreElement.text = GameManager.instance.currentAmountOfPoints.ToString();
    }
}