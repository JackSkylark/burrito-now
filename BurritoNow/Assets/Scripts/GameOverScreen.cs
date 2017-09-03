using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour {

    Canvas _renderer;

	// Use this for initialization
	void Start () {
        _renderer = this.GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        var numberOfLives = GameManager.Instance.Lives;

        if (numberOfLives > 0)
        {
            _renderer.enabled = false;   
        } else
        {
            var hasClickedEnter = Input.GetKeyDown(KeyCode.Return);
            if (hasClickedEnter)
            {
                GameManager.Instance.Reset();
            }

            _renderer.enabled = true;
        }
	}
}
