using System;
using System.Text.RegularExpressions;

namespace EXERCISE_23_PG612{
    class List<T>{

        private T[] _list;
        private int _usedPlaces;

        public List(int size){
            this._list = new T[size];
            this._usedPlaces = 0;
        }

        //Method that adds obj to the array
        public void Add(T obj){
            if ((this._usedPlaces == this._list.Length) || (this._list.Length == 0)){
                int i = 0;
                T[] AuxList;

                if (this._list.Length == 0)
                    AuxList = new T[1];
                else
                    AuxList = new T[this._list.Length*2];

                foreach (T elem in this._list){
                    AuxList[i] = elem;
                    i++;
                }
                    this._list = AuxList;
            }

                this._list[this._usedPlaces] = obj;
                this._usedPlaces++;
        }

        //To string method override
        public override string ToString(){
            string str = ""; 

            for (int i = 0; i< this._usedPlaces; i++){
                str += this._list[i]+" ";
            }

            return str;
        }  

        //Method that returns the element in the valid index of the List
        public T GetValue(int index){
            return (T) this._list.GetValue(index);
        }
        
        //Method that removes an element in a valid index of the List
        public bool Rmv(int index){
            bool boolean = false;
            int i;

            if (this._usedPlaces > 0){
                if ((index < this._usedPlaces) && (index >= 0)){
                    boolean = true;
                    
                    this._usedPlaces --;

                    for (i = index; i < this._usedPlaces; i++)
                        this._list[i] = this._list[i+1];    
                
                }
            }
            return boolean;
        }

        //Method that adds an element in a valid index of the List
        public void Add_by_Index(int index, T obj){
            int i = 0;
            
             if ((index < this._usedPlaces) && (index >= 0)){
                 
                if ((this._usedPlaces == this._list.Length) || (this._list.Length == 0)){
                    T[] AuxList;
                    
                    if (this._list.Length == 0)
                        AuxList = new T[1];
                    else
                        AuxList = new T[this._list.Length*2];

                    foreach (T elem in this._list){
                        AuxList[i] = elem;
                        i++;
                    }

                        this._list = AuxList;
                }

                this._usedPlaces++;
                for (i = this._usedPlaces-1; i != index; i--)
                    this._list[i] = this._list[i-1];
                
                this._list[index] = obj;
            }
        }

        public void Clear(){
            this._list = null;
            this._usedPlaces = 0;
        }

        public T Find(Predicate<T> match){
            if (this._list != null)
                return Array.Find(this._list, match);

            return default(T);
        }
        
    }
}
