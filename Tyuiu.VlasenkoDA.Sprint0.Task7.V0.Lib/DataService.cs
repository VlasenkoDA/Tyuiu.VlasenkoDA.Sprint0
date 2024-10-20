namespace Tyuiu.VlasenkoDA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        //Пример циклической структуры, цикл с параметрами For
        public static int[] AdditionArrays(int[] numOne, int[] NumTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + NumTwo[i];
            }
            return resultArray;
        }

    }
}
