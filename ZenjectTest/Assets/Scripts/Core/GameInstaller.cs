using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("GameInstaller InstallBindings called");
        //Core
        Container.BindInterfacesTo<GameManager>().AsSingle().NonLazy();

        //Input
        Container.Bind<IInputService>().To<InputService>().AsSingle();
        //Player
        Container.Bind<PlayerController>().AsSingle();
    }
}
