using UnityEngine;
using TMPro;

public class KeypadLock : MonoBehaviour
{
    [Header("Keypad Configuration")]
    public TextMeshPro passCodeDisplay; // Pantalla para mostrar el c�digo

    private string enteredNumber = ""; // N�mero actualmente ingresado
    private string savedNumber = "";   // N�mero guardado despu�s de presionar Enter

    // Propiedad p�blica para acceder al n�mero guardado desde otros scripts
    public string SavedNumber => savedNumber;

    // Actualiza la pantalla del teclado
    private void UpdateDisplay()
    {
        if (passCodeDisplay != null)
        {
            passCodeDisplay.text = enteredNumber;
        }
    }

    // A�ade un d�gito al n�mero actual
    public void AddDigit(string digit)
    {
        enteredNumber += digit;
        UpdateDisplay();
    }

    // Limpia el n�mero actual (no el guardado)
    public void ClearCode()
    {
        enteredNumber = "";
        UpdateDisplay();
    }

    // Guarda el n�mero actual (para acceso desde otros scripts)
    public void SaveNumber()
    {
        savedNumber = enteredNumber;
        Debug.Log("N�mero guardado: " + savedNumber);
        // No limpiamos enteredNumber para que siga visible
    }
}