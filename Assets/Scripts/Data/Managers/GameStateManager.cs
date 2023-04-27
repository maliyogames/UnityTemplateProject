using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Managers/GameState Manager")]


public class GameStateManager : SingletonScriptableObject<GameStateManager>
{
    [FancyHeader("GAMESTATE MANAGER", 3f, "#D4AF37", 8.5f, order = 0)]
    [Space(order = 1)]
    [CustomProgressBar(hideWhenZero = true, label = "m_loadingTxt"), SerializeField] public float m_loadingBar;
    [HideInInspector] public string m_loadingTxt;
    [HideInInspector] public bool m_loadingDone = false;
    [Space]



    [HeaderAttribute("Managers")]
    [SerializeField] private ApplicationManager m_applicationManager;
    private ApplicationManager m_saveApplicationManager;

    [SerializeField] private EconomyManager m_economyManager;
    private EconomyManager m_saveEconomyManager;

    
    public static EconomyManager EconomyManager
    {
        get { return Instance.m_economyManager; }

    }
    public static ApplicationManager ApplicationManager
    {
        get { return Instance.m_applicationManager; }

    }

    public void Init()
    {
        GameStateManager.EconomyManager.InitializeValues();
        
    }

}