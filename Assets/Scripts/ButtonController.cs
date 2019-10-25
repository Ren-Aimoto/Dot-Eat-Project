﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    //GameManager
    public GameObject gamemanager;

    //StageCreater
    public GameObject stagecreater;

    //EnemyGenerator
    public GameObject enemygenerator;

    //ボタン群
    public GameObject PlayButton;
    public GameObject HowToButton;
    public GameObject BackButton;
    public GameObject TimeAttackButton;
    public GameObject ScoreAttackButton;
    public GameObject BacktoTitleButton;
    public GameObject TryAgainButton;
    public GameObject RankingButton;

    //How to Play UI
    public GameObject HowtoText;
    public GameObject HowtoBG;

    //TitleText
    public GameObject TitleText;

    //GameModeSelect UI
    public GameObject GamemodeBG;
    public GameObject TextGamemodeSelect;

    //ResultUI
    public GameObject ResultBG;
    public GameObject ResultText;



    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PushPlayButton()
    {
        GamemodeBG.SetActive(true);
        TextGamemodeSelect.SetActive(true);
        PlayButton.SetActive(false);
        HowToButton.SetActive(false);
        TitleText.SetActive(false);
        ResultBG.SetActive(false);
        ResultText.SetActive(false);
        gamemanager.GetComponent<GameManager>().currentstatus = GameManager.GameStatus.Title;
    }

    public void PushHowtoButton()
    {
        HowtoText.SetActive(true);
        HowtoBG.SetActive(true);
        PlayButton.SetActive(false);
        HowToButton.SetActive(false);
        TitleText.SetActive(false);
    }

    public void PushBackButton()
    {
        HowtoText.SetActive(false);
        HowtoBG.SetActive(false);
        PlayButton.SetActive(true);
        HowToButton.SetActive(true);
        TitleText.SetActive(true);
        ResultBG.SetActive(false);
        ResultText.SetActive(false);
        gamemanager.GetComponent<GameManager>().currentstatus = GameManager.GameStatus.Title;
    }

    public void PushTryAgainButton()
    {
        GamemodeBG.SetActive(true);
        TextGamemodeSelect.SetActive(true);
        ResultBG.SetActive(false);
        ResultText.SetActive(false);
    }


    public void PushTimeAttackButton()
    {
        stagecreater.GetComponent<StageCreater>().StageCreation();
        enemygenerator.GetComponent<EnemyGenerator>().EnemyGenerate();
        GamemodeBG.SetActive(false);
        TextGamemodeSelect.SetActive(false);
        gamemanager.GetComponent<GameManager>().currentstatus = GameManager.GameStatus.TimeAttackonGoing;
        gamemanager.GetComponent<GameManager>().GameStart();
    }

    public void PushScoreAttackButton()
    {
        stagecreater.GetComponent<StageCreater>().StageCreation();
        enemygenerator.GetComponent<EnemyGenerator>().EnemyGenerate();
        GamemodeBG.SetActive(false);
        TextGamemodeSelect.SetActive(false);
        gamemanager.GetComponent<GameManager>().currentstatus = GameManager.GameStatus.ScoreAttackonGoing;
        gamemanager.GetComponent<GameManager>().GameStart();
    }

}
