using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryHeap
{
   /* struct HeapNode <T> where T : IComparable
    {
        public T payload;
    }*/

    class BinaryHeap <T> where T : IComparable
    {
        private List<T> _array;
        bool _minHeap=true;

        public BinaryHeap(bool minHeap)
        {           
            _minHeap = minHeap;
            _array = new List<T>();
            _array.Add(default(T)); //for easing of implementation position 0 is ignored
        }

        public BinaryHeap():this(true)
        {    
      
        }

        public bool isEmpty()
        {
            if(_array.Count==1)
            {
                return true;
            }
            return false;

        }

        public int Count
            {
                get { return (_array.Count - 1); }
            }
        public void Clear()
        {
            _array.Clear();
            _array.Add(default(T)); //for easing of implementation position 0 is ignored
        }

        public void Insert(T node)
        {
            _array.Add(node);
            bubbleUp(node, _array.Count-1);
        }

        public T ExtractRootNode() //returns and removes peak Node
        {
            T toReturn = Peek();
            T lastElement = _array.Last();
            _array[1] = lastElement;
            _array.RemoveAt(_array.Count-1);
            bubbleDown(lastElement, 1);
            return toReturn;
        }

        public T Peek()
        {
            return _array.ElementAt(1);
        }

        private void bubbleDown(T node, int k)
        {
            if ((2*k) > (_array.Count-1))
            {
                return;
            }
            T leftChild = _array[2*k];
            T rightChild = leftChild; //in case there is no right child just assume that right child equals left child
            if ( !( (2*k + 1) > (_array.Count-1) ) )
            {
                rightChild = _array[2*k + 1];
            }

            if(_minHeap==false)
            { 
                if (node.CompareTo(leftChild) >=0 && node.CompareTo(rightChild) >=0)
                {
                    return;
                }
                else if (leftChild.CompareTo(node) > 0 && leftChild.CompareTo(rightChild) >=0  )
                {
                    swap(k, k * 2);
                    bubbleDown(node, k * 2);
                   
                }
                else if (rightChild.CompareTo(node) > 0 && rightChild.CompareTo(leftChild)>=0)
                {
                    swap(k, k * 2 + 1);
                    bubbleDown(node, k * 2+1);
                }
            }
            else
            {
                if (node.CompareTo(leftChild) <= 0 && node.CompareTo(rightChild) <= 0)
                {
                    return;
                }
                else if (leftChild.CompareTo(node) < 0 && leftChild.CompareTo(rightChild) <= 0)
                {
                    swap(k, k * 2);
                    bubbleDown(node, k * 2);
                }
                else if (rightChild.CompareTo(node) < 0 && rightChild.CompareTo(leftChild) <= 0)
                {
                    swap(k , k * 2 + 1);
                    bubbleDown(node, k * 2+1);
                }
            }
            return;
        }

        private void bubbleUp(T node,int k)
        {
            int parentIndex = k / 2;
            if(parentIndex==0) //we reached root
            {
                return;
            }
            T parentNode = _array[parentIndex];
            if( (_minHeap==true && node.CompareTo(parentNode)<0)
                || (_minHeap == false && node.CompareTo(parentNode) > 0))
            {
                swap(k, parentIndex);
                bubbleUp(node, parentIndex);
            }
        }

      

        private void swap(int p1,int p2)
        {
            T temp = _array[p1];
            _array[p1] = _array[p2];
            _array[p2] = temp;
        }
    }
}
