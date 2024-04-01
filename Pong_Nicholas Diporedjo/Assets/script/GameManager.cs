using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayersScoreL = 0;
    public int PlayersScoreR = 0;

    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        txtPlayerScoreL.text = PlayersScoreL.ToString();
        txtPlayerScoreR.text = PlayersScoreR.ToString();
    }

    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayersScoreR = PlayersScoreR + 10;
            txtPlayerScoreR.text = PlayersScoreR.ToString();
        }
        else
        {
            PlayersScoreL = PlayersScoreL + 10;
            txtPlayerScoreL.text = PlayersScoreL.ToString();
        }
    }
}

