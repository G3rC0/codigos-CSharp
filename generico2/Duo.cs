namespace Generico
{
    class Duo<T>
    {
        private T _primero;
        private T _segundo;

        public Duo(T v1, T v2)
        {
            _primero = v1;
            _segundo=v2;
        }

        public T GetPrimero()
        {
            return _primero;
        }
        public T GetSegundo()
        {
            return _segundo;
        }
        public void Intercambiar()
        {
            T aux;
            aux=_primero;
            _primero = _segundo;
            _segundo = aux;
        }
    }
}