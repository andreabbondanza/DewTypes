using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DewCore.Algorithms.Sort
{
    /// <summary>
    /// Get sorter
    /// </summary>
    public class HeapSort
    {
        private static HeapSort _sorter = null;
        private int heapSize;

        public static HeapSort GetSorter()
        {
            if (_sorter == null)
                _sorter = new HeapSort();
            return _sorter;

        }

        private void BuildHeap<T>(T[] arr) where T : IComparable<T>
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Swap<T>(T[] arr, int x, int y) where T : IComparable<T>
        {
            T temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify<T>(T[] arr, int index) where T : IComparable<T>
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left].CompareTo(arr[index]) > 0)
            {
                largest = left;
            }

            if (right <= heapSize && arr[right].CompareTo(arr[largest]) > 0)
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
        /// <summary>
        /// Perform the sort and return it to a new TResult collection
        /// </summary>
        /// <typeparam name="T">Collection type</typeparam>
        /// <typeparam name="TResult">Result collection type</typeparam>
        /// <param name="coll">collection</param>
        /// <returns></returns>
        public TResult PerformHeapSortGeneric<T, TResult>(ICollection<T> coll) where T : IComparable<T> where TResult : class, ICollection<T>, new()
        {
            TResult result = new TResult();
            T[] arr = new T[coll.Count];
            coll.CopyTo(arr, 0);
            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
            foreach (var item in arr)
            {
                result.Add(item);
            }
            return result;
        }
        private void BuildHeapBaseType<T>(T[] arr) where T : IComparable
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                HeapifyBaseType(arr, i);
            }
        }

        private void SwapBaseType<T>(T[] arr, int x, int y) where T : IComparable
        {
            T temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void HeapifyBaseType<T>(T[] arr, int index) where T : IComparable
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left].CompareTo(arr[index]) > 0)
            {
                largest = left;
            }

            if (right <= heapSize && arr[right].CompareTo(arr[largest]) > 0)
            {
                largest = right;
            }

            if (largest != index)
            {
                SwapBaseType(arr, index, largest);
                HeapifyBaseType(arr, largest);
            }
        }
        /// <summary>
        /// Perform the sort and return it to a new TResult collection
        /// </summary>
        /// <typeparam name="T">Collection type</typeparam>
        /// <typeparam name="TResult">Result collection type</typeparam>
        /// <param name="coll">collection</param>
        /// <returns></returns>
        public TResult PerformHeapSortBaseType<T, TResult>(ICollection<T> coll) where T : IComparable where TResult : class, ICollection<T>, new()
        {
            TResult result = new TResult();
            T[] arr = new T[coll.Count];
            coll.CopyTo(arr, 0);
            BuildHeapBaseType(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                SwapBaseType(arr, 0, i);
                heapSize--;
                HeapifyBaseType(arr, 0);
            }
            foreach (var item in arr)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
