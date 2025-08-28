using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPiece : MonoBehaviour
{
    public Color changeColor = Color.white;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        NewColor();
    }

    //Update in Scene view
    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        NewColor();
    }

    //CHange color
    private void NewColor()
    {
        spriteRenderer.color = changeColor;
    }
}