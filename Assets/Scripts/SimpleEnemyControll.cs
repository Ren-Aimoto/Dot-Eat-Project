using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyControll : MonoBehaviour {

    //Animatorコンポーネント
    public Animator myAnimator;

    //敵キャラの移動スピード
    private float movespeed = 0.01f;

    //敵キャラは今+/-のどちらに移動しているのか
    private bool IsMovePlus = true;


	// Use this for initialization
	void Start () {
        myAnimator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        myAnimator.SetFloat("Speed", 1);
        EnemyMove();
    }


    private void EnemyMove()
    {
        Vector3 Pos = this.transform.position;
        if (IsMovePlus) {
            if (gameObject.tag == "HorizontalEnemy")
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
                this.transform.position = new Vector3(Pos.x + movespeed, Pos.y, Pos.z);
                if (this.transform.position.x > 4.5f)
                {
                    IsMovePlus = false;
                }
            }
            if (gameObject.tag == "VerticalEnemy")
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
                this.transform.position = new Vector3(Pos.x, Pos.y, Pos.z + movespeed);
                if (this.transform.position.z > 4.5f)
                {
                    IsMovePlus = false;
                }
            }
        }
        if (!IsMovePlus)
        {
            if (gameObject.tag == "HorizontalEnemy")
            {
                this.transform.rotation = Quaternion.Euler(0, 270, 0);
                this.transform.position = new Vector3(Pos.x - movespeed, Pos.y, Pos.z);
                if (this.transform.position.x < -4.5f)
                {
                    IsMovePlus = true;
                }
            }
            if (gameObject.tag == "VerticalEnemy")
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                this.transform.position = new Vector3(Pos.x, Pos.y, Pos.z - movespeed);
                if (this.transform.position.z < -4.5f)
                {
                    IsMovePlus = true;
                }
            }
        }
    }
}
