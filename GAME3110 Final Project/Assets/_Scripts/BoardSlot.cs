using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardSlot : MonoBehaviour
{
    bool hasPiece = false;

    [SerializeField] Sprite yellowSprite;
    [SerializeField] Sprite redSprite;

    public enum PieceColour
    {
        NONE,
        YELLOW,
        RED
    };

    public PieceColour pieceColour;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetSprite();   
    }

    public bool GetHasPiece()
    {
        return hasPiece;
    }

    public PieceColour GetPieceColour()
    {
        return pieceColour;
    }
    
    void SetSprite()
    {
        if (pieceColour == PieceColour.RED)
        {
            GetComponent<Image>().color = Color.white;
            GetComponent<Image>().sprite = redSprite;
        }
        else if (pieceColour == PieceColour.YELLOW)
        {
            GetComponent<Image>().color = Color.white;
            GetComponent<Image>().sprite = yellowSprite;
        }
        else
        {
            GetComponent<Image>().color = Color.clear;
        }
    }
}
