
using System;

public interface IInputService
{
    event Action<float> OnMovePerformed;
}
