using UnityEngine;

public class SportCar : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private GameObject ligthsFront;
    [SerializeField] private GameObject ligthsBack;
    [SerializeField] private Material colorCurrent;
    private Color colorDefault;

    #endregion

    #region METHODS_MONOBEHAVIOUR

    private void Start()
    {
        colorDefault = colorCurrent.color;
    }

    #endregion

    #region METHODS_PUBLIC

    public void ChangeColor(string color)
    {
        switch (color)
        {
            case "color1":
                colorCurrent.color = Color.red;
                break;
            case "color2":
                colorCurrent.color = Color.blue;
                break;
            case "color3":
                colorCurrent.color = Color.green;
                break;
            default:
                colorCurrent.color = colorDefault;
                break;
        }
    }

    public void TurnLightsFront()
    {
        ligthsFront.SetActive(!ligthsFront.activeSelf);
    }

    public void TurnLightsBack()
    {
        ligthsBack.SetActive(!ligthsBack.activeSelf);
    }

    public void ChangeScale(bool up)
    {
        if (up)
        {
            float x = gameObject.transform.localScale.x + 0.01f;
            float y = gameObject.transform.localScale.y + 0.01f;
            float z = gameObject.transform.localScale.z + 0.01f;
            gameObject.transform.localScale = new Vector3(x, y, z);
        }
        else
        {
            float x = gameObject.transform.localScale.x - 0.01f;
            float y = gameObject.transform.localScale.y - 0.01f;
            float z = gameObject.transform.localScale.z - 0.01f;

            if (x < 0.01f)
            {
                return;
            }

            gameObject.transform.localScale = new Vector3(x, y, z);
        }
    }

    #endregion
}