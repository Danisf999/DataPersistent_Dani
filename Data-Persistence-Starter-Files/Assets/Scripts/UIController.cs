using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private InputField nameInputField;
    [SerializeField] private Text bestScore;
    void Start()
    {
        bestScore.text = "Best Score: " + DataController._instance.DataLoad("PlayerName") + ": " + DataController._instance.DataLoadInt("BestScore");
        nameInputField.text = DataController._instance.DataLoad("PlayerName");
    }

    public void SetName()
    {
        DataController._instance.DataSave("CurrentPlayer", nameInputField.text);
    }
}
