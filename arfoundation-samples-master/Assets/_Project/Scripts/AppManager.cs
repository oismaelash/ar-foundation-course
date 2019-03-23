using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AppManager : MonoBehaviour
{
    #region VARIABLES

    public static AppManager Instance;
    public SportCar SportCar { get; set; }
    [SerializeField] private ARSessionOrigin arSessionOrigin;

    #endregion

    #region METHODS_MONOBEHAVIOUR

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    #region METHODS_AUX

    public void TurnPlanesShow()
    {
        bool activeOrDisable = arSessionOrigin.trackablesParent.gameObject.activeSelf;
        arSessionOrigin.trackablesParent.gameObject.SetActive(!activeOrDisable);
    }

    #endregion
}