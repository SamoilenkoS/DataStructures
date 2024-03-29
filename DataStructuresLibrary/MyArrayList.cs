﻿using System;
using System.Collections.Generic;

namespace DataStructuresLibrary
{
    public class MyArrayList : IMyList
    {
        private const int DefaultSize = 4;
        private const double Coef = 1.5;
        private int _count;
        private int[] _array;

        public int Capacity => _array.Length;
        public int Length => _count;

        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _array[index];
            }
            set => throw new NotImplementedException();
        }

        public MyArrayList() : this(DefaultSize)
        {
        }

        public MyArrayList(int size)
        {
            size = size > DefaultSize ? (int)(size * Coef) : DefaultSize;
            _array = new int[size];
        }

        public MyArrayList(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentException();
            }

            int size = array.Length > DefaultSize ? (int)(array.Length * Coef) : DefaultSize;
            _array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }

            _count = array.Length;
        }

        public void AddBack(int itemToAdd)
        {
            if(Capacity == Length)
            {
                int[] newArray = new int[(int)(_array.Length * Coef)];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
            }

            _array[_count++] = itemToAdd;
        }

        public int[] ToArray()
        {
            int[] result = new int[Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = _array[i];
            }

            return result;
        }

        public void AddFront(int itemToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, int itemToAdd)
        {
            throw new NotImplementedException();
        }

        public int RemoveBack()
        {
            throw new NotImplementedException();
        }

        public int RemoveFront()
        {
            throw new NotImplementedException();
        }

        public int RemoveByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveNValuesBack(int n)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveNValuesFront(int n)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveNValuesByIndex(int index, int n)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int element)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int MaxIndex()
        {
            throw new NotImplementedException();
        }

        public int MinIndex()
        {
            throw new NotImplementedException();
        }

        public void Sort(bool ascending = true)
        {
            throw new NotImplementedException();
        }

        public int RemoveByValue(int value)
        {
            throw new NotImplementedException();
        }

        public int RemoveByValueAll(int value)
        {
            throw new NotImplementedException();
        }

        public void AddFront(IEnumerable<int> items)
        {
            throw new NotImplementedException();
        }

        public void AddBack(IEnumerable<int> items)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, IEnumerable<int> items)
        {
            throw new NotImplementedException();
        }
    }
}
