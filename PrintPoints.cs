using TMPro;
using UnityEngine;

public class PrintPoints : MonoBehaviour
{
    public TextMeshProUGUI scoreElement;

    public void Update()
    {
        this.scoreElement.text = GameManager.instance.currentAmountOfPoints.ToString();
    }
}