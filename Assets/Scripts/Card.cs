using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public Text strengthText;
    public Button upgradeButton;

    private int strengthValue = 0;

    private void Start()
    {
        upgradeButton.onClick.AddListener(OnUpgradeButtonClick);
    }

    private void OnUpgradeButtonClick()
    {
        int randomValue = Random.Range(1, 11); // 生成 1 到 10 之間的隨機整數
        strengthValue += randomValue;
        UpdateStrengthText();
    }

    private void UpdateStrengthText()
    {
        strengthText.text = "力量: " + strengthValue.ToString();
    }
}
