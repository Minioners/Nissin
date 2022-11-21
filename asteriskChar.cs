using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class asteriskChar : MonoBehaviour
{
    public InputField mainInputField;

    void Start()
    {
        // changes the password symbol. 0 = $, 1 = ! 2 = £ and so on.
        mainInputField.asteriskChar = "$!£%&*"[0];
    }
}