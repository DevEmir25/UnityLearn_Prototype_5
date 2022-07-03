using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffucultyButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;
    public int diffuculty;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDiffuculty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDiffuculty()
    {
        Debug.Log(button.gameObject.name + "clicked");
        gameManager.StartGame(diffuculty);
    }
}
