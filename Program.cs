using System;

namespace SpiralReading
{
    /*
     * 사용자로부터 숫자 N을 입력받으면, N X N 배열을 나선형으로 읽어서 출력한다.
     * N = 5인 경우,
     * [  1 |  2 |  3 |  4 |  5 ]
     * [  6 |  7 |  8 |  9 | 10 ]
     * [ 11 | 12 | 13 | 14 | 15 ]
     * [ 16 | 17 | 18 | 19 | 20 ]
     * [ 21 | 22 | 23 | 24 | 25 ]
     * => [5, 4, 3, 2, 1, 6, 11, 16, 21, 22, 23, 24, 25, 20,
     *     15, 10, 9, 8, 7, 12, 17, 18, 19, 14, 13]
     */
    class Program
    {
        static int ROW = 1;
        static int COLUMN = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("1. 만약에 입력값이 1인 경우 1을 출력하는가?");
            whenIfInputIsOne();
            Console.WriteLine();

            Console.WriteLine("2. 만약에 입력값이 2인 경우 {2, 1, 3, 4}를 출력하는가?");
            whenIfInputIsTwo();
            Console.WriteLine();

            Console.WriteLine("3. 만약에 입력값이 3인 경우 {3, 2, 1, 4, 7, 8, 9, 6, 5}를 출력하는가?");
            whenIfInputIsThree();
            Console.WriteLine();

            Console.WriteLine("4. 만약에 입력값이 4인 경우 {4, 3, 2, 1, 5, 9, 13, 14, 15, 16, 12, 8, 7, 6, 10, 11}를 출력하는가?");
            whenIfInputIsFour();
            Console.WriteLine();

            Console.WriteLine("5. 만약에 입력값이 5인 경우 {5, 4, 3, 2, 1, 6, 11, 16, 21, 22, 23, 24, 25, 20, 15, 10, 9, 8, 7, 12, 17, 18, 19, 14, 13}를 출력하는가?");
            whenIfInputIsFive();
            Console.WriteLine();
        }

        /// <summary>
        /// 만약에 입력값이 5인 경우 {5, 4, 3, 2, 1, 6, 11, 16, 21, 22, 23, 24, 25, 20, 15, 10, 9, 8, 7, 12, 17, 18, 19, 14, 13}를 출력하는가?
        /// </summary>
        private static void whenIfInputIsFive()
        {
            int input = 5;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 5, 4, 3, 2, 1, 6, 11, 16, 21, 22, 23, 24, 25, 20, 15, 10, 9, 8, 7, 12, 17, 18, 19, 14, 13 };
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        /// <summary>
        /// 만약에 입력값이 4인 경우 {4, 3, 2, 1, 5, 9, 13, 14, 15, 16, 12, 8, 7, 6, 10, 11}를 출력하는가?
        /// </summary>
        private static void whenIfInputIsFour()
        {
            int input = 4;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 4, 3, 2, 1, 5, 9, 13, 14, 15, 16, 12, 8, 7, 6, 10, 11 };
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        /// <summary>
        /// 만약에 입력값이 3인 경우 {3, 2, 1, 4, 7, 8, 9, 6, 5}를 출력하는가?
        /// </summary>
        private static void whenIfInputIsThree()
        {
            int input = 3;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 3, 2, 1, 4, 7, 8, 9, 6, 5 };
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        /// <summary>
        /// 만약에 입력값이 2인 경우 {2, 1, 3, 4}를 출력하는가?
        /// </summary>
        private static void whenIfInputIsTwo()
        {
            int input = 2;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 2, 1, 3, 4 };
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        /// <summary>
        /// 만약에 입력값이 1인 경우 나선형으로 출력하는가?
        /// </summary>
        private static void whenIfInputIsOne()
        {
            int input = 1;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 1 };
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        // 결과를 검증한다.
        private static void assertThat(int[] result, int[] arr)
        {
            bool bResult = false;

            Console.Write("출력값 : ");
            for (int i = 0; i < ROW * COLUMN ; i++)
            {
                if (arr[i] == result[i])
                {
                    bResult = true;
                }
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("답 : " + bResult);
        }

        static int[,] makeArray(int input)
        {
            int[,] arr = new int[input, input];
            int number = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    number++;
                    arr[i, j] = number;
                }
            }
            return arr;
        }

        // 나선형으로 숫자를 출력한다.
        static int[] counterClockspiral(int input, int[,] arr)
        {
            int endingRowIndex = 0;
            int endingColumnIndex = 0;
            int i, startingRowIndex = 0, startingColumnIndex = input - 1;
            int[] results = new int[input * input];
            int ri = 0; // 결과물들 인덱스

            // startingRowIndex - 시작하는 행 인덱스 
            // endingRowIndex - 끝나는 행 인덱스
            // startingColumnIndex - 시작하는 열 인덱스 
            // endingColumnIndex - 끝나는 열 인덱스
            // i - 반복 인덱스

            // 출력 숫자의 개수를 초기화한다. 
            int cnt = 0;
            // 오른쪽에서 왼쪽으로 간 횟수를 초기화한다.
            int rightToLeftCnt = 0;
            // 위에서 아래로 간 횟수를 초기화한다.
            int upToDownCnt = 0;
            // 왼쪽에서 오른쪽으로 간 횟수를 초기화한다.
            int leftToRightCnt = 0;
            // 아래에서 위로 간 횟수를 초기화한다.
            int downToUpCnt = 0;
            // 총 숫자의 개수를 구한다. 
            int total = ROW * COLUMN;

            while (true)
            {
                if (cnt == total)
                    break;

                if (rightToLeftCnt > 0)
                {
                    startingRowIndex = rightToLeftCnt;
                    endingRowIndex = rightToLeftCnt;
                    startingColumnIndex = input - 2;
                    endingColumnIndex = rightToLeftCnt;
                }

                // 모서리의 길이가 홀수면, 마지막에 정중앙에 도달하게 한다.
                if (cnt == total - 1 && input % 2 == 1)
                {
                    startingRowIndex = (input - 1) / 2;
                    startingColumnIndex = startingRowIndex;
                    endingColumnIndex = startingRowIndex;
                }

                // 오른쪽에서 왼쪽으로 출력한다.
                for (i = startingColumnIndex; i >= endingColumnIndex; i--)
                {
                    results[ri] = arr[startingRowIndex, i];
                    ri++;
                    cnt++;
                }
                rightToLeftCnt++;
                startingRowIndex++;

                if (cnt == total)
                    break;

                if (upToDownCnt == 0)
                {
                    endingRowIndex = input - 1;
                    startingColumnIndex = 0;
                }
                else
                {
                    endingRowIndex = input - 2;
                    startingColumnIndex = upToDownCnt;
                }

                // 위에서 아래로 출력한다.
                for (i = startingRowIndex; i <= endingRowIndex; i++)
                {
                    results[ri] = arr[i, startingColumnIndex];
                    ri++;
                    cnt++;
                }
                upToDownCnt++;
                startingColumnIndex++;
                
                if (cnt == total)
                    break;

                if (leftToRightCnt == 0)
                {
                    startingRowIndex = input - 1;
                    endingColumnIndex = input - 1;
                }
                else
                {
                    startingRowIndex = input - leftToRightCnt - 1;
                    endingRowIndex = startingRowIndex;
                    endingColumnIndex = input - 2;
                }
                
                // 왼쪽에서 오른쪽으로 출력한다.
                for (i = startingColumnIndex; i <= endingColumnIndex; i++)
                {
                    results[ri] = arr[startingRowIndex, i];
                    ri++;
                    cnt++;
                }
                leftToRightCnt++;
                startingRowIndex--;
                
                if (cnt == total)
                    break;

                if (downToUpCnt == 0)
                {
                    
                    startingColumnIndex = input - 1;
                }
                endingRowIndex = downToUpCnt + 1;

                // 아래에서 위로 출력한다.
                for (i = startingRowIndex; i >= endingRowIndex; i--)
                {
                    results[ri] = arr[i, endingColumnIndex];
                    ri++;
                    cnt++;
                }
                downToUpCnt++;
            }

            return results;
        }
    }
}
