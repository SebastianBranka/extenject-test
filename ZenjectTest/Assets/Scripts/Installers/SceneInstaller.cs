using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("SceneInstaller InstallBindings called");
        //UI
        Container.Bind<UIController>().AsSingle();

    }
}
