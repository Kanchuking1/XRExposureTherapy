using UnityEngine;
using GoogleARCore.Examples.HelloAR;

[RequireComponent(typeof(HelloARController))]
public class SpiderSceneHandler : MonoBehaviour
{
    [SerializeField]
    GameObject BigSpidersPrefab;
    [SerializeField]
    GameObject MidSpidersPrefab;
    [SerializeField]
    GameObject SmallSpidersPrefab;
    [SerializeField]
    HelloARController mainController;

    private void Start()
    {
        mainController = GetComponent<HelloARController>();
        //Setting a default value for the prefab
        mainController.ClickPrefab(SmallSpidersPrefab);
    }

    public void SetBig()
    {
        mainController.ClickPrefab(BigSpidersPrefab);
    }

    public void SetSmall()
    {
        mainController.ClickPrefab(SmallSpidersPrefab);
    }

    public void SetMid()
    {
        mainController.ClickPrefab(MidSpidersPrefab);
    }
}
