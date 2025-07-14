using UnityEngine;

public class KeypadButton : MonoBehaviour
{
    public KeypadLock keypadLock;
    public string digitOrAction; // Puede ser "Enter", "Clear" o un dígito como "1", "2", etc.

    public void PressButton()
    {
        if (digitOrAction == "Enter")
        {
            keypadLock.SaveNumber();
        }
        else if (digitOrAction == "Clear")
        {
            keypadLock.ClearCode();
        }
        else
        {
            keypadLock.AddDigit(digitOrAction);
        }
    }
}