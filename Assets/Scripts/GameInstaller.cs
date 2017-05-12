using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Calculator>().AsSingle().NonLazy();
        Container.Bind<NumberParser>().AsSingle().NonLazy();
    }
}