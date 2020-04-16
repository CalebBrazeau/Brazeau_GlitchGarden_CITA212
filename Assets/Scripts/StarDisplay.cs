using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StarDisplay : MonoBehaviour
{

    [SerializeField] int intStars = 100;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = intStars.ToString();
    }

    public void AddStars(int intamount)
    {
        intStars += intamount;
        UpdateDisplay();
    }

    public void SpendStars(int intamount)
    {
        if (intStars >= intamount)
        {
            intStars -= intamount;
            UpdateDisplay();
        }
    }
}
