using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeBehaviour : MonoBehaviour
{
    private Image buttonImage;
    private Button button;

    public void ReactToMouseEnter()
    {
        if (GameManager.gInstance.GetPoints() >= GameManager.gInstance.GetUpgradeValue())
        {
            buttonImage.color = Color.green;
            this.button.interactable = true;
        }
        else
        {
            buttonImage.color = Color.red;
        }
    }

    public void ReactToMouseExit()
    {
        buttonImage.color = Color.gray;
    }

    public void UpgradeIncrement()
    {
        int currentValue = GameManager.gInstance.GetIncrement();

        GameManager.gInstance.UpdateIncrementValue();
        GameManager.gInstance.UpdateUpgradeValue();
    }

    public void Start()
    {
        button = this.GetComponent<Button>();
        buttonImage = this.GetComponent<Image>();
        button.interactable = false;
    }
}