using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPiece : MonoBehaviour
{
    public Color changeColor = Color.white;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        NewColor();
    }

    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        NewColor();
    }

    private void NewColor()
    {
        spriteRenderer.color = changeColor;
    }
}