using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] GameObject board;

    [SerializeField] GameObject boardSlot;
    public GameObject[,] boardSlotArray;

    // Start is called before the first frame update
    void Start()
    {
        boardSlotArray = new GameObject[6, 7];

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                boardSlotArray[i, j] = Instantiate(boardSlot, new Vector3(0, 0, 0), Quaternion.identity);
                boardSlotArray[i, j].transform.SetParent(board.transform);
                boardSlotArray[i, j].transform.localScale = new Vector3(1,1,1);
                boardSlotArray[i, j].GetComponent<BoardSlot>().pieceColour = BoardSlot.PieceColour.NONE;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
