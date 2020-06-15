
namespace Playground
{
    class Cartige
    {
        private int _bullet;

        public Cartige(int ammoAmount)
        {
            _bullet = ammoAmount;
        }

        public bool HasNext()
        {
            return _bullet > 0;
        }

        public int GetBullet()
        {
            _bullet--;
            return _bullet;
        }
    }
}
