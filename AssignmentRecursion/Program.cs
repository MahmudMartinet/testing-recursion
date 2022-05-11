using System;

namespace AssignmentRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Simulant(arr, 0);

            Console.WriteLine("Question 2");
            Console.Write("Enter N: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k1 = int.Parse(Console.ReadLine());
            int[] arrK = new int[k1];
            Duplicate(arrK, 0, 1, n1);

            Console.WriteLine("Question 3");
            Console.Write("Enter N: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k2 = int.Parse(Console.ReadLine());
            int[] arrK2 = new int[k2];
            Combinations(arrK2, 0, 1, n2);

            Console.WriteLine("Question 7");
            Console.WriteLine("Enter N: ");
            int n3 = int.Parse(Console.ReadLine());
            int[] arrN1 = new int[n3];
            for(int i = 0; i < arrN1.Length; i++)
            {
                arrN1[i] = i + 1;
            }
            Permutations(arrN1, 0);

        }

        static void Simulant(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach(int j in arr)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Simulant(arr, index + 1);
                }
            }
        }

        static void Duplicate(int[] arrDup, int indexDup, int startDup, int endDup)
        {
            if (indexDup >= arrDup.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arrDup.Length; i++)
                {
                    if (i < arrDup.Length - 1)
                    {
                        Console.Write("{0} ", arrDup[i]);
                    }
                    else
                    {
                        Console.Write(arrDup[i]);
                    }
                    Console.Write("), ");
                }
            }
            else
            {
                for (int i = startDup; i <= endDup; i++)
                {
                    arrDup[indexDup] = i;
                    Duplicate(arrDup, indexDup + 1, i, endDup);
                }
            }
        }

        static void Combinations(int[] arrCom, int indexCom, int startCom, int endCom)
        {
            if (indexCom >= arrCom.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arrCom.Length; i++)
                {
                    if (i < arrCom.Length - 1)
                    {
                        Console.Write("{0} ", arrCom[i]);
                    }
                    else
                    {
                        Console.Write(arrCom[i]);
                    }
                    Console.Write("), ");
                }
            }
            else
            {
                for (int i = startCom; i <= endCom; i++)
                {
                    arrCom[indexCom] = i;
                    Combinations(arrCom, indexCom + 1, i, endCom);
                }
            }
        }
        //Question 4
        static void Subsets(string[] arrSet, int indexSet, int startSet, int endSet)
        {
            
            if (indexSet >= arrSet.Length)
            {
                Console.Write("(");
                for(int i = 0; i < arrSet.Length; i++)
                {
                   // Console.Write("{0}",)
                }
            }
        }
        //Question 7
        static void Permutations(int[] arrPerm, int indexPerm)
        {
            if (indexPerm == arrPerm.Length)
            {
                Console.Write("(");
                for(int i = 0; i < arrPerm.Length; i++)
                {
                    if (i < arrPerm.Length - 1)
                    {
                        Console.Write("{0}", arrPerm[i]);
                    }
                    else
                    {
                        Console.Write(arrPerm[i]);
                    }
                }
                Console.Write("), ");
            }
            else
            {
                for (int i = indexPerm; i < arrPerm.Length; i++)
                {
                    int temp = arrPerm[i];
                    arrPerm[i] = arrPerm[indexPerm];
                    arrPerm[indexPerm] = temp;
                    Permutations(arrPerm, indexPerm + 1);
                    temp = arrPerm[i];
                    arrPerm[i] = arrPerm[indexPerm];
                    arrPerm[indexPerm] = temp;
                }
            }
        }

    }
}
