using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Exempel
{
    public class SortingExempel
    {
        private int[] ToBeSorted;
        private Stopwatch watch;

        private Dictionary<string, TimeSpan> results;
        public SortingExempel()
        {
            Init(20000);
        }
        public SortingExempel(int NumberOfItems)
        {
            Init(NumberOfItems);
        }
        public void Init(int Items)
        {
            int[] tal = { 7, 8, 2, 12, 44, 223, 23, 23, 23, 5, 6, 1, 3, 2, 0, -20, 3 };
            //ToBeSorted = tal;
            //Sortering
            ToBeSorted = new int[Items];
            RandomArray();
            results = new Dictionary<string, TimeSpan>();
            watch = new Stopwatch();

            BubbleSort();

            // InsertionSort();
            
            // SelectionSort();

            // QuickSort();

            // MergeSort();

            // BuildHeap();

            Console.WriteLine("Körtider för sorteringsalgoritmerna med {0} värden.", ToBeSorted.Length);
            foreach (KeyValuePair<string, TimeSpan> item in results)
            {
                Console.WriteLine("Algoritm: {0}, Körtid: {1}ms, Ticks: {2}", item.Key, item.Value.Milliseconds, item.Value.Ticks);
            }
        }

        private void RandomArray()
        {
            Random rnd = new Random();
            for(int i = 0;i < ToBeSorted.Length; i++)
            {
                ToBeSorted[i] = rnd.Next(0, ToBeSorted.Length);
            }
        }

        private int[] BubbleSort()
        {
            int[] a = (int[])ToBeSorted.Clone();
            int t;
            watch.Reset();
            watch.Start();
            for (int j = 0; j <= a.Length - 2; j++) {
                for (int i = 0; i <= a.Length - 2; i++) {
                    if (a[i] > a[i + 1]) {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            watch.Stop();
            results.Add("BubbleSort", watch.Elapsed);
            return a;
        }

        private int[] InsertionSort()
        {
            int[] a = (int[])ToBeSorted.Clone();
            int i, j;
            watch.Reset();
            watch.Start();
            for (i = 1; i < a.Length; i++) {
                int item = a[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;) {
                    if (item < a[j]) {
                        a[j + 1] = a[j];
                        j--;
                        a[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
            watch.Stop();
            results.Add("InsertionSort", watch.Elapsed);
            return a;
        }

        private int[] SelectionSort()
        {
            int[] a = (int[])ToBeSorted.Clone();
            int tmp, min_key;

            watch.Reset();
            watch.Start();    
            for (int j = 0; j < a.Length - 1; j++) {
                min_key = j;
                for (int k = j + 1; k < a.Length; k++) {
                    if (a[k] < a[min_key]) {
                        min_key = k;
                    }
                }
                tmp = a[min_key];
                a[min_key] = a[j];
                a[j] = tmp;
            }
            watch.Stop();
            results.Add("SelectionSort", watch.Elapsed);
            return a;
        }

        #region quicksort
        private int[] QuickSort()
        {
            watch.Reset();
            watch.Start();    
            int[] qs = (int[])ToBeSorted.Clone();
            QuickSort(qs, 0, qs.Length - 1);
            watch.Stop();
            results.Add("QuickSort", watch.Elapsed);
            return qs;
        }
        private void QuickSort(int[] arr, int left, int right)
        {
            if (left < right) {
                int pivot = Partition(arr, left, right);
                if (pivot > 1) {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
        private int Partition(int[] arr, int left, int right)
        {
            int pivoValue = arr[left];
            int lo = left;
            int hi = right;
            while(true) {
                while(hi > lo && arr[hi] >= pivoValue) {
                    hi--;
                }
                if(hi <= lo) {
                    arr[lo] = pivoValue;
                    return lo;
                }
                arr[lo] = arr[hi];
                lo++;

                while(lo < hi && arr[lo] < pivoValue) {
                    lo++;
                }
                if(lo >= hi) {
                    arr[hi] = pivoValue;
                    return hi;
                }
                arr[hi] = arr[lo];
            }
        }
        #endregion
        #region mergesort
        private int[] MergeSort()
        {
            int[] a = (int[])ToBeSorted.Clone();
            int[] b = new int[a.Length];
            watch.Reset();
            watch.Start();
            MergeSort(a, b, 0, a.Length - 1);
            watch.Stop();
            results.Add("MergeSort", watch.Elapsed);
            return a;
        }
        private void MergeSort(int[] a, int[] b, int start, int end)
        {
            if(start >= end) {
                return;
            }
            int mid = (start + end) / 2;
            MergeSort(a, b, start, mid);
            MergeSort(a, b, mid + 1, end);
            Merge(a, b, start, mid, end);
        }
        private void Merge(int[] a, int[] b, int start, int mid, int end)
        {
            int left = start;
            int right = mid + 1;
            int i = left;
            while((left <= mid) && (right <= end)) {
                if(a[left] <= a[right]) {
                    b[i] = a[left];
                    left++;
                }
                else {
                    b[i] = a[right];
                    right++;
                }
                i++;
            }
            for(int j = left; j <= mid; j++) {
                b[i] = a[j];
                i++;
            }
            for(int j = right; j <= end; j++) {
                b[i] = a[j];
                i++;
            }
            for(int j = start; j < end; j++) {
                a[j] = b[j];
            }
        }
        #endregion

        private void Heapify(int[] arr, int n, int i)  
        {  
            int largest = i; 
            int l = 2 * i + 1; // left = 2 * i + 1  
            int r = 2 * i + 2; // right = 2 * i + 2  

            if (l < n && arr[l] > arr[largest]) {
                largest = l;
            }

            if (r < n && arr[r] > arr[largest]) {
                largest = r;  
            }
            if (largest != i)  {  
                int swap = arr[i];  
                arr[i] = arr[largest];  
                arr[largest] = swap;  

                Heapify(arr, n, largest);  
            }  
        }

        private void HeapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--) 
            {
                Heapify(arr, n, i);
            }
            for (int i = n-1; i>=0; i--) 
            {
                int temp = arr[0]; 
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0); 
            }            
        }
        private void BuildHeap(int[] arr, int n)
        {
            int startIdx = (n / 2) - 1;
            for (int i = startIdx; i >= 0; i--)  
            {  
                Heapify(arr, n, i);  
            }
        }
        private void Swap(int[] arr, int pos1,  int pos2)
        {
            int tmp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = tmp;
        }
        private void RemoveHeapMax(int[] arr, ref int count)
        {
            Swap(arr, arr[count -1], arr[0]);
            count--;
            int parent = 0, swapChild;
            while(true)
            {
                int child1 = 2 * parent + 1;
                int child2 = 2 * parent + 2;
                if(child1 >= count) child1 = parent;
                if(child2 >= count) child2 = parent;
                if((arr[parent] >= arr[child1]) && (arr[parent] >= arr[child2])) {
                    break;
                }
                if(arr[child1]  > arr[child2]) {
                    swapChild = child1;
                }
                else {
                    swapChild = child2;
                }
                Swap(arr, arr[parent], arr[swapChild]);
                parent = swapChild;
            }
        }
        private void BuildHeap()
        {  
            int[] arr = (int[])ToBeSorted.Clone();
            int n = arr.Length;
            watch.Reset();
            watch.Start();            
            BuildHeap(arr, n);
            watch.Stop();
            results.Add("BuildHeap", watch.Elapsed);
        }  
    }
}