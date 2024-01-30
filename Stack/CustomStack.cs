﻿using System;
using System.Collections;

namespace Stack
{
	public class CustomStack<T>:IEnumerable<T>
	{
		private const int InitialCapacity = 4;
		private T[] items = new T[InitialCapacity];



		public CustomStack()
		{
		}

		public int Count { get; private set; }

		public void Push(T item)
		{
			if (items.Length == Count)
			{
				Resize();
			}

			items[Count] = item;

			Count++;
		}

		public T Pop()
		{
			if (Count == 0)
			{
				throw new InvalidOperationException("No elements");
			}

			T removedItem = items[Count - 1];

			Count--;

			return removedItem;
		}

		private void Resize()
		{
			T[] copy = new T[items.Length * 2];

			for (int i = 0; i < Count; i++)
			{
				copy[i] = items[i];

			}
			items = copy;
		}

        public IEnumerator<T> GetEnumerator()
        {
			for (int i = Count - 1; i >= 0; i--)
			{
				yield return items[i];
			}
        }

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
