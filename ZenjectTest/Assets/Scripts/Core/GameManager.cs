using UnityEngine;
using Zenject;

public class GameManager : ITickable
{
    private readonly PlayerController _player;

    public GameManager(PlayerController player)
    {
        _player = player;
    }

    public void Tick()
    {
        //_player.Tick();
        //Debug.Log("GameManager Tick called");
    }
}
