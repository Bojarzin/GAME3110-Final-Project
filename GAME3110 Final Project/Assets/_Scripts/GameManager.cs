using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static GameManager GetManager()
    {
        return instance;
    }

    [SerializeField] BoardManager boardManager;

    public enum PlayerTurn
    {
        YELLOW,
        RED
    };

    public PlayerTurn playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        playerTurn = PlayerTurn.YELLOW;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTurn()
    {
        playerTurn = playerTurn == PlayerTurn.RED ? PlayerTurn.YELLOW : PlayerTurn.RED;
    }

    public void InsertPiece()
    {
        //boardManager.FillSlot
    }

    public void ColumnZeroButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 0].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 0].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 0].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
    public void ColumnOneButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 1].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 1].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 1].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
    public void ColumnTwoButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 2].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 2].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 2].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
    public void ColumnThreeButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 3].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 3].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 3].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
    public void ColumnFourButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 4].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 4].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 4].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
    public void ColumnFiveButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 5].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 5].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 5].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
    public void ColumnSixButton()
    {
        bool flag = false;
        for (int i = 5; i >= 0 && flag == false; i--)
        {
            if (boardManager.boardSlotArray[i, 6].GetComponent<BoardSlot>().GetPieceColour() == BoardSlot.PieceColour.NONE)
            {
                if (playerTurn == PlayerTurn.RED)
                {
                    boardManager.boardSlotArray[i, 6].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.RED;
                }
                else if (playerTurn == PlayerTurn.YELLOW)
                {
                    boardManager.boardSlotArray[i, 6].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.YELLOW;
                }
                flag = true;
                ChangeTurn();
            }
        }
    }
}
