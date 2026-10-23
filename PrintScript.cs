using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PrintScript : MonoBehaviour
{
    public TextMeshProUGUI scoreElement;
    public TextMeshProUGUI upgradePriceElement;

    public void Start()
    {
    }

    public void Update()
    {
        this.upgradePriceElement.text = GameManager.gInstance.GetUpgradeValue().ToString();
        this.scoreElement.text = GameManager.gInstance.GetPoints().ToString();
    }
}