using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuWindow : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(Log);
        _slider.onValueChanged.AddListener(ChangeSlider);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveAllListeners();
        _slider.onValueChanged.RemoveAllListeners();
    }

    private void Log()
    {
        Debug.Log("Click button");
    }

    private void ChangeSlider(float value)
    {
        Debug.Log(value);
    }

}
