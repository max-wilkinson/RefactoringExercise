namespace RefactoringExercise
{
    public class MyExpandableList
    {
        private object[] _elements = new object[10];
        private bool _readOnly;
        private int numberOfElementsInList = 0;

        public bool ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        public int NumberOfElementsInList
        {
            get { return numberOfElementsInList; }
        }

        public int Capacity
        {
            get { return _elements.Length; }
        }

        public void Add(object child)
        {
            if (_readOnly)
            {
                return;
            }

            if (CapacityExceeded())
            {
                Grow();
            }

            AddElement(child);
        }

        private void AddElement(object child)
        {
            _elements[numberOfElementsInList] = child;

            numberOfElementsInList++;
        }

        private void Grow()
        {
            object[] newElements = new object[_elements.Length + 10];

            for (int i = 0; i < numberOfElementsInList; i++)
            {
                newElements[i] = _elements[i];
            }

            _elements = newElements;
        }

        private bool CapacityExceeded()
        {
            return numberOfElementsInList + 1 > _elements.Length;
        }
    }
}