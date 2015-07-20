using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySot
{
    public class JaggrtArraySort
    {
        public static void Sort(int [][] arrForSort, object compareType)
        {
            ICustomCompare comType = compareType as ICustomCompare;
            if (comType == null)
            {
                throw new NullReferenceException("Неверно задан тип сортировки");
            }
            Sort(arrForSort, comType);
        }
        public static void Sort(int [][] arrForSort, ICustomCompare compareType)
        {
            #region Exceptions
            if (compareType == null)
            {
                throw new NullReferenceException("Неверно задан тип сортировки");
            }
            if (arrForSort == null)
            {
                throw new NullReferenceException("Сортируемый массив не инициализирован");
            }
            
            foreach (int[] a in arrForSort)
                if (a == null)
                {
                    throw new NullReferenceException("Одна или более строк массива ссылается на null"); ;
                }
            #endregion
            for (int i=0;i<arrForSort.Length-1;i++)
                for (int j = 0; j < arrForSort.Length - 1; j++)
                if (0<compareType.CustomCompare(arrForSort[j],arrForSort[j+1]))
                {
                    int[] temp = arrForSort[j];
                    arrForSort[j] = arrForSort[j + 1];
                    arrForSort[j + 1] = temp;
                }
        }
    }
}
