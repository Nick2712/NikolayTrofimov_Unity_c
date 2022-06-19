using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal sealed class PlayerBall : Player
    {
        private float _timeSpeedChanged;
        private float _timeInvul;
        private readonly float _defaultSpeed;
        private bool _isInvul;

        public PlayerBall()
        {
            _defaultSpeed = _speed;
        }

        public void ChangeSpeed(float time, float speed)
        {
            Debug.Log("�������� ����������");
            _timeSpeedChanged = time;
            _speed = speed;
        }

        public void Die()
        {
            if (!_isInvul) Debug.Log("������");
        }

        public void Invul(float time)
        {
            Debug.Log("������������ ��������");
            _timeInvul = time;
            _isInvul = true;
        }

        public override void Move()
        {
            base.Move();
            if(_timeInvul > 0)
            {
                _timeInvul -= Time.fixedDeltaTime;
                if (_timeInvul <= 0)
                {
                    _isInvul = false;
                    Debug.Log("������������ ���������");
                }
            }
            if(_timeSpeedChanged > 0)
            {
                _timeSpeedChanged -= Time.fixedDeltaTime;
                if (_timeSpeedChanged <= 0)
                {
                    _speed = _defaultSpeed;
                    Debug.Log("�������� ���������");
                }
            }
        }
    }
}
