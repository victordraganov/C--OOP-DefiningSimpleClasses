namespace Cs_OOP_Homework_2
{
    public class GenericList<T>
    {
        private T[] elements;
        private uint count;
        private uint capacity;

        public GenericList(uint inputLength)
        {
            this.elements = new T[inputLength];
            this.count = 0;
            this.capacity = inputLength;
        }

        public void AddElement(T element)
        {
            if (this.count == this.capacity)
            {
                this.AutoGrow();
            }

            this.elements[this.count] = element;
            count++;
        }

        private void AutoGrow()
        {
            T[] newBuffer = new T[this.capacity * 2];

            elements.CopyTo(newBuffer); //TTTUUUUKKKK
        }

        private bool IsEmpty()
        {
            return this.count == 0;
        }
    }
}
