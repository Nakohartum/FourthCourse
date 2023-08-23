using _Root.Code.Fire;
using _Root.Code.UpdateManager;
using UnityEngine;

namespace Asteroids
{
    public class PlayerFactory
    {
        private Player _playerViewPrefab;

        public PlayerFactory(Player playerViewPrefab)
        {
            _playerViewPrefab = playerViewPrefab;
        }
        public PlayerController CreatePlayer(ExecutableManager executableManager)
        {
            var playerView = Object.Instantiate(_playerViewPrefab);
            var playerModel = playerView.PlayerModel;
            var moveTransform = new MovePhysics(playerModel.Rigidbody, playerModel.Speed);
            var rotation = new RotationShip(playerView.transform);
            var shoot = new PhysicsShoot(playerModel.Bullet);
            var ship = new Ship(moveTransform, rotation, shoot);
            var playerController = new PlayerController(playerView, ship, executableManager);
            return playerController;
        }
    }
}