using System;
using System.Collections.Generic;

namespace Queue{
    public class PriorityQueue<T>{
        private List<(T Item, int Priority)> queue = new List<(T, int)>();
        public void AddElement(T item, int priority){
            queue.Add((item, priority));
            SortQueue();
        }
        private void SortQueue(){
            for (int i = 0; i < queue.Count - 1; i++){
                for (int j = 0; j < queue.Count - i - 1; j++){
                    if (queue[j].Priority > queue[j + 1].Priority){
                        var temp = queue[j];
                        queue[j] = queue[j + 1];
                        queue[j + 1] = temp;
                    }
                }
            }
        }
        public T DelElement(){
            if (Empty){
                throw new InvalidOperationException("Черга пуста");
            }
            T item = queue[0].Item;
            queue.RemoveAt(0);
            return item;
        }
        public T Bigger(){
            if (Empty){
                throw new InvalidOperationException("Черга пуста");
            }
            return queue[0].Item;
        }
        public bool Empty{
            get{
                return queue.Count == 0;
            }
        }
        public int Count(){
            return queue.Count;
        }
    }
}
