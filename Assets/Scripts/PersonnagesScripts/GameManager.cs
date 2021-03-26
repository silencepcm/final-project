using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    // partie singleton
    #region Singleton
    public static GameManager Instance;
    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one instance of GameManager found!");
            return;
        }
        Init();
        Instance = this;

    }
    #endregion

    // propriété player du gamemanger, reference du player accecible partout
    public Player p { get; private set; }
    public Enemy1 e1 { get; private set; }
    public Enemy2 e2 { get; private set; }

    // methode lancer a la création du singleton
    void Init()
    {
        // aplle du constructeur de player
        p = new Player();
        e1 = new Enemy1();
        e2 = new Enemy2();
    }


}
