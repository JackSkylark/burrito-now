using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesTextScript : MonoBehaviour {

    private Text _textComponent;

    // Use this for initialization
    void Start()
    {
        _textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _textComponent.text = GameManager.Instance.Lives.ToString();
    }
}
