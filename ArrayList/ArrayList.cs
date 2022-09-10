using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class ArrList
    {
        private static int DEFAULT_SIZE = 2;
        private string[] array;
        private int size;

        public ArrList(int size)
        {
            array = new string[size];
        }

        public ArrList()
        {
            array = new string[DEFAULT_SIZE];
        }

        public void addAtTail(string data)
        {

            if (size == array.Length)
            {
                increaseArraySize();
            }
            array[size] = data;
            size++;
        }

        public void addAtFront(string data)
        {

            if (size == array.Length)
            {
                increaseArraySize();
            }
            if (size >= 0)
            {
                Array.Copy(array, 0, array, 1, size);
            }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {

            if (index < 0 || index >= size)
            {
                return;
            }
            if (size - 1 - index >= 0)
            {
                Array.Copy(array, index + 1, array, index, size - 1 - index);
            }
            array[size - 1] = null;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        public String getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : null;
        }

        public void setAt(int index, String data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public ArrayListIterator getIterator()
        {
            return new ArrayListIterator(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            String[] newArray = new String[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}