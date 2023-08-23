using System;
using _Root.Code.UpdateManager;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids
{
    public class PlayerController : IUpdatable, IDisposable
    {
        private Player _player;
        private Ship _ship;
        private Camera _camera;
        private PlayerModel _playerModel;
        private ExecutableManager _executableManager;

        public PlayerController(Player player, Ship ship, ExecutableManager executableManager)
        {
            _player = player;
            _playerModel = _player.PlayerModel;
            _ship = ship;
            _camera = Camera.main;
            _executableManager = executableManager;
            _player.OnCollideWithPlayer += OnCollide;
            _executableManager.AddUpdatable(this);
        }


        public void Update(float deltaTime)
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(_player.transform.position);
            _ship.Rotation(direction);
            _ship.Move(horizontal, vertical, deltaTime);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.IncreaseSpeed(_playerModel.Acceleration);
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.DecreaseSpeed(_playerModel.Acceleration);
            }
            if (Input.GetButtonDown("Fire1"))
            {
                _ship.Shoot(_playerModel.Barrel.position, _playerModel.Barrel.rotation, _playerModel.Barrel.up,
                    _playerModel.Force);
            }
        }

        private void OnCollide(Collision2D collision)
        {
            _playerModel.Hp.ChangeCurrentHealth(_playerModel.Hp.Current - 5, _player.gameObject);
        }

        public void Dispose()
        {
            _executableManager.RemoveUpdatable(this);
        }
    }
}