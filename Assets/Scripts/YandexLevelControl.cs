using System.Collections;
using Ilumisoft.SkillDrive.Input;
using UnityEngine;
using YG;

public class YandexLevelControl : MonoBehaviour
{
    [SerializeField] private GameObject mobileInputCanvas;
        
    public static YandexLevelControl Instance { get; private set; }
        
    private void Awake()
    {
        Instance = this;
        YandexGame.InitLang();
        MultiTextUI.lang = YandexGame.lang;
    }

    public void SwicthMobileInputsState(bool state)
    {
        mobileInputCanvas.SetActive(state);
    }

    private void Start()
    {
        StartCoroutine(YandexSDKEnabledCoroutine());
    }

    public IEnumerator YandexSDKEnabledCoroutine()
    {
        yield return new WaitUntil(() => YandexGame.SDKEnabled);
        YandexGame.InitEnvirData();
        VehiclePlayerInput.isMobile = YandexGame.EnvironmentData.isMobile;
        SwicthMobileInputsState(YandexGame.EnvironmentData.isMobile);
        //TODO Yandex prefab to Main Menu
    }
}