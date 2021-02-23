using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public enum TeamOwner
    {
        YELLOW,
        BLUE
    };

    TeamOwner teamOwner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public TeamOwner GetTeamOwner()
    {
        return teamOwner;
    }

    public void SetTeamOwner(TeamOwner _teamOwner)
    {
        teamOwner = _teamOwner;
    }
}
