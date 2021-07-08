using Cysharp.Threading.Tasks;
using UnityEngine;
using UniversalUnity.Helpers.UI.BaseUiElements;

public class TestSceneController : MonoBehaviour
{
    [SerializeField] private BaseInteractableUiElement baseUiElementSwitch;
    [SerializeField] private BaseUiElement baseUiElement;
    
    private void Awake()
    {
        baseUiElementSwitch.OnClick 
            += UniTask.Action
                (async () => await baseUiElement.EnableOrDisable(!baseUiElement.IsEnabled, true));
    }
}