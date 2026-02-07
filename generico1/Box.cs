namespace generecidad
{
    class Box<T>
    {
        private T _content{get; set;}
    public Box(T contenido)
        {
            _content = contenido;
        }
        public void UpdateContent(T newValue)
        {
            _content = newValue;
        }

        public T getContent()
        {
            return _content;
        }

        public string GetTypeName()
        {
            return($"{typeof(T)}");
        }
    }
}