using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    //CountDownText
    public GameObject TextCountDown;

    //Enemy Controller
    public GameObject EnemyController;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator CountdownCoroutine()
    {

        TextCountDown.SetActive(true);
        TextCountDown.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1.0f);

        TextCountDown.SetActive(true);
        TextCountDown.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1.0f);

        TextCountDown.SetActive(true);
        TextCountDown.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1.0f);

        TextCountDown.SetActive(true);
        TextCountDown.GetComponent<Text>().text = "Start!";
        yield return new WaitForSeconds(1.0f);

        TextCountDown.SetActive(false);
        //GameStatusをアップデート



    }
}
