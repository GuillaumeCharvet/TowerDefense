using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }

    public Text _timerText = null;

    private Text timerText { get { return _timerText; } set { _timerText = value; } }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void SetTimer(float time)
    {
        timerText.text = "Timer: " + time.ToString("F1");
    }
}
