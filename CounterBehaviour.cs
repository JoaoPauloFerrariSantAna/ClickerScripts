//using System.Diagnostics;
using UnityEngine;
using TMPro;

public class CounterBehaviour : MonoBehaviour
{
    public TextMeshProUGUI scoreElement;
    public GameManager manager;

    private int counterValue = 0;

    public void Increment()
    {
        this.counterValue += this.manager.increment;
        this.scoreElement.text = this.counterValue.ToString();
    }
}
