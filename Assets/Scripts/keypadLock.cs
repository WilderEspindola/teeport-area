using UnityEngine;
using TMPro;

public class KeypadLock : MonoBehaviour
{
    [Header("Keypad Configuration")]
    public TextMeshPro passCodeDisplay; // Pantalla para mostrar el código

    private string enteredNumber = ""; // Número actualmente ingresado
    private string savedNumber = "";   // Número guardado después de presionar Enter

    // Propiedad pública para acceder al número guardado desde otros scripts
    public string SavedNumber => savedNumber;

    // Actualiza la pantalla del teclado
    private void UpdateDisplay()
    {
        if (passCodeDisplay != null)
        {
            passCodeDisplay.text = enteredNumber;
        }
    }

    // Añade un dígito al número actual
    public void AddDigit(string digit)
    {
        enteredNumber += digit;
        UpdateDisplay();
    }

    // Limpia el número actual (no el guardado)
    public void ClearCode()
    {
        enteredNumber = "";
        UpdateDisplay();
    }

    // Guarda el número actual (para acceso desde otros scripts)
    public void SaveNumber()
    {
        savedNumber = enteredNumber;
        Debug.Log("Número guardado: " + savedNumber);
        // No limpiamos enteredNumber para que siga visible
    }
}