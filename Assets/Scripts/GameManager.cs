using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private string text = "Game Manager";

    public string GetText()
    {
        return text;
    }
}
