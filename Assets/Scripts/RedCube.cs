using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RedCube : Cube
{
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 50;
        colourSelected = GameObject.Find("Colour Selected").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        RotateCube();
        DisplayColour();
    }
    //Polymorphism
    public override void DisplayColour()
    {
        colourSelected.gameObject.SetActive(true);
        colourSelected.text = "Cube is Red";
    }
    private void OnMouseExit()
    {
        SetTextInactive();
    }
}
