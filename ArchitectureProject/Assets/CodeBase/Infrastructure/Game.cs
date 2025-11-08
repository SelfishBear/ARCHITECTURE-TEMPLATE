using CodeBase.Logic;
using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public  GameStateMachine _stateMachine;
        public static IInputService InputService;

        public Game(ICoroutineRunner coroutineRunner, LoadingCurtain curtain)
        {
            _stateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), curtain);
        }
    }
}