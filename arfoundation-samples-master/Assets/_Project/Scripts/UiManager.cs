using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    #region VARIABLES

    [SerializeField] private Button btnTurnLightsFront;
    [SerializeField] private Button btnTurnLightsBack;
    [SerializeField] private Button btnColor1;
    [SerializeField] private Button btnColor2;
    [SerializeField] private Button btnColor3;
    [SerializeField] private Button btnScaleUp;
    [SerializeField] private Button btnScaleDown;
    [SerializeField] private Button btnTurnPlanes;

    #endregion

    #region METHODS_MONOBEHAVIOUR

    private void Start()
    {
        btnColor1.onClick.AddListener(() => OnButtonColorClicked("color1"));
        btnColor2.onClick.AddListener(() => OnButtonColorClicked("color2"));
        btnColor3.onClick.AddListener(() => OnButtonColorClicked("color3"));
        btnTurnLightsFront.onClick.AddListener(OnButtonLightsFrontClicked);
        btnTurnLightsBack.onClick.AddListener(OnButtonLightsBackClicked);
        btnScaleUp.onClick.AddListener(() => OnButtonScaleClicked(true));
        btnScaleDown.onClick.AddListener(() => OnButtonScaleClicked(false));
        btnTurnPlanes.onClick.AddListener(OnButtonTurnPlanesClicked);
    }

    #endregion

    #region METHODS_BUTTON

    private void OnButtonColorClicked(string color)
    {
        AppManager.Instance.SportCar.ChangeColor(color);
    }

    private void OnButtonLightsFrontClicked()
    {
        AppManager.Instance.SportCar.TurnLightsFront();
    }

    private void OnButtonLightsBackClicked()
    {
        AppManager.Instance.SportCar.TurnLightsBack();
    }

    private void OnButtonScaleClicked(bool up)
    {
        AppManager.Instance.SportCar.ChangeScale(up);
    }

    private void OnButtonTurnPlanesClicked()
    {
        AppManager.Instance.TurnPlanesShow();
    }

    #endregion
}