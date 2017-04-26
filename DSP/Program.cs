using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP
{   
    public enum Status
    {
        TRUE =1,
        FALSE=0,
        OK   =1,
        ERROR=0,
        INFEASIBLE=-1,
        OVERFLOW=-2
    }
    class Program
    {

        static void Main(string[] args)
        {
            LinearList<int> listA=new LinearList<int>();
            LinearList<int>.InitList(ref listA);
            LinearList<int>.ListTraverse(listA, Visit<int>);
        }
        static void Visit<T>(T a)
        {
            Console.Write(a);
        }
    }

    delegate void Visit(int s);
    delegate void Visit<TYPE>(TYPE s);
    class SequenceList:LinearList
    {
        int List_Init_Size = 100;
        int List_Increment = 10;
        int start = 0;
        int length = 0;
        int listsize = 0;
        public int GetSize()
        {
            return sizeof(int);
        }
    }
    class LinearList// Static Functions interger
    {
        public static Status InitList(ref LinearList L)
        {

            return Status.OK;
        }
        public Status InitList()
        {

            return Status.OK;
        }
        public static Status DestroyList(ref LinearList L)
        {
            return Status.OK;
        }

        public static Status ClearList(ref LinearList L)
        {
            return Status.OK;
        }

        public static Status ListEmpty(LinearList L)
        {
            return Status.TRUE;
        }

        public static int ListLenght(LinearList L)
        {
            return -1;
        }

        public static Status GetElem(LinearList L, int i, ref int elem)
        {
            return Status.OK;
        }

        public static int LocateElem(LinearList L, int elem, Comparer<int> comp)
        {
            return 0;
        }

        public static Status PriorElem(LinearList L, int cur_e, ref int pre_e)
        {
            return Status.OK;
        }

        public static Status NextElem(LinearList L, int cur_e, ref int next_e)
        {
            return Status.OK;
        }

        public static Status ListInsert(ref LinearList L, int i, int elem)
        {
            return Status.OK;
        }

        public static Status ListDelete(ref LinearList L, int i, int elem)
        {
            return Status.OK;
        }

        public static Status ListTraverse(LinearList L, Visit visit)
        {
            Visit v = new Visit(visit);
            v(1);
            return Status.OK;
        }
    }
    class LinearList<TYPE>// Static Functions
    {
        public static Status InitList(ref LinearList<TYPE> L)
        {
            return Status.OK;
        }

        public static Status DestroyList(ref LinearList<TYPE> L)
        {
            return Status.OK;
        }

        public static Status ClearList(ref LinearList<TYPE> L)
        {
            return Status.OK;
        }

        public static Status ListEmpty(LinearList<TYPE> L)
        {
            return Status.TRUE;
        }

        public static int ListLenght(LinearList<TYPE> L)
        {
            return -1;
        }

        public static Status GetElem(LinearList<TYPE> L, int i, ref TYPE elem)
        {
            return Status.OK;
        }

        public static int LocateElem(LinearList<TYPE> L, TYPE elem, Comparer<TYPE> comp)
        {
            return 0;
        }

        public static Status PriorElem(LinearList<TYPE> L, TYPE cur_e, ref TYPE pre_e)
        {
            return Status.OK;
        }

        public static Status NextElem(LinearList<TYPE> L, TYPE cur_e, ref TYPE next_e)
        {
            return Status.OK;
        }

        public static Status ListInsert(ref LinearList<TYPE> L, int i, TYPE elem)
        {
            return Status.OK;
        }

        public static Status ListDelete(ref LinearList<TYPE> L, int i, TYPE elem)
        {
            return Status.OK;
        }

        public static Status ListTraverse(LinearList<TYPE> L, Visit<TYPE> visit)
        {
            Visit<TYPE> v = new Visit<TYPE>(visit);
            return Status.OK;
        }
    }
}
