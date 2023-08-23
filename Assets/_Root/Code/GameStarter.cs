using _Root.Code.UpdateManager;
using Asteroids;
using UnityEngine;

namespace _Root.Code
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private Player _playerPrefab;
        private ExecutableManager _executableManager;
        private void Start()
        {
            _executableManager = new ExecutableManager();
            var playerFactory = new PlayerFactory(_playerPrefab);
            playerFactory.CreatePlayer(_executableManager);
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _executableManager.Update(deltaTime);
        }
    }
}