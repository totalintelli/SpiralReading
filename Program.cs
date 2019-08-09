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

            Console.WriteLine("6. 만약에 입력값이 6인 경우 {6, 5, 4, 3, 2, 1, 7, 13, 19, 25, 31, 32, 33, 34, 35, 36, 30, 24, 18, 12, 11, 10," + 
                                   " 9, 8, 14, 20, 26, 27, 28, 29, 23, 17, 16, 15, 21, 22 }를 출력하는가?");
            whenIfInputIsSix();
            Console.WriteLine();

            Console.WriteLine("7. 만약에 입력값이 7인 경우 {7, 6, 5, 4, 3, 2, 1, 8, 15, 22, 29, 36, 43, 44, 45, 46, 47, 48, 49, 42, 35, 28, 21," +
                                   " 14, 13, 12, 11, 10, 9, 16, 23, 30, 37, 38, 39, 40, 41, 34, 29, 20, 19, 18, 17, 24, 31, 32, 33, 26, 25 }를 출력하는가?");
            whenIfInputIsSeven();
            Console.WriteLine();

            Console.WriteLine("7. 만약에 입력값이 10인 경우 {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 21, 31, 41, 51, 61, 71, 81, 91, 92, 93, 94, 95," +
                                   " 96, 97, 98, 99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 19, 18, 17, 16, 15, 14, 13, 12, 22, 32, 42, 52, 62, 72," + 
                                   " 82, 83, 84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 29, 28, 27, 26, 25, 24, 23, 33, 43, 53, 63, 73, 74, 75, " +
                                   " 76, 77, 78, 68, 58, 48, 38, 37, 36, 35, 34, 44, 54, 64, 65, 66, 67, 57, 47, 46, 45, 55, 56}를 출력하는가?");
            whenIfInputIsTen();
            Console.WriteLine();
        }

        /// <summary>
        /// 만약에 입력값이 10인 경우 {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 21, 31, 41, 51, 61, 71, 81, 91, 92, 93, 94, 95,
        /// 96, 97, 98, 99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 19, 18, 17, 16, 15, 14, 13, 12, 22, 32, 42, 52, 62, 72,
        /// 82, 83, 84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 29, 28, 27, 26, 25, 24, 23, 33, 43, 53, 63, 73, 74, 75,
        /// 76, 77, 78, 68, 58, 48, 38, 37, 36, 35, 34, 44, 54, 64, 65, 66, 67, 57, 47, 46, 45, 55, 56}를 출력하는가?
        /// </summary>
        private static void whenIfInputIsTen()
        {
            int input = 10;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 21, 31, 41, 51, 61, 71, 81, 91, 92, 93, 94, 95,
                                               96, 97, 98, 99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 19, 18, 17, 16, 15, 14, 13,
                                               12, 22, 32, 42, 52, 62, 72, 82, 83, 84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 29,
                                               28, 27, 26, 25, 24, 23, 33, 43, 53, 63, 73, 74, 75, 76, 77, 78, 68, 58, 48, 38, 37,
                                               36, 35, 34, 44, 54, 64, 65, 66, 67, 57, 47, 46, 45, 55, 56};
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        /// <summary>
        /// 만약에 입력값이 7인 경우 {7, 6, 5, 4, 3, 2, 1, 8, 15, 22, 29, 36, 43, 44, 45, 46, 47, 48, 49, 42, 35, 28, 21,
        ///  14, 13, 12, 11, 10, 9, 16, 23, 30, 37, 38, 39, 40, 41, 34, 29, 20, 19, 18, 17, 24, 31, 32, 33, 26, 25 }를 출력하는가?
        /// </summary>
        private static void whenIfInputIsSeven()
        {
            int input = 7;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 7, 6, 5, 4, 3, 2, 1, 8, 15, 22, 29, 36, 43, 44, 45, 46, 47, 48, 49, 42, 35, 28, 21,
                                               14, 13, 12, 11, 10, 9, 16, 23, 30, 37, 38, 39, 40, 41, 34, 29, 20, 19, 18, 17, 24,
                                               31, 32, 33, 26, 25};
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
        }

        /// <summary>
        /// 만약에 입력값이 6인 경우 {6, 5, 4, 3, 2, 1, 7, 13, 19, 25, 31, 32, 33, 34, 35, 36, 30, 24, 18, 12, 11, 10," 
        /// " 9, 8, 14, 20, 26, 27, 28, 29, 23, 17, 16, 15, 21, 22 }를 출력하는가?
        /// </summary>
        private static void whenIfInputIsSix()
        {
            int input = 6;
            ROW = input;
            COLUMN = input;
            int[] expectedResult = new int[] { 6, 5, 4, 3, 2, 1, 7, 13, 19, 25, 31, 32, 33, 34, 35, 36, 30, 24, 18, 12, 11, 10,
                                               9, 8, 14, 20, 26, 27, 28, 29, 23, 17, 16, 15, 21, 22};
            int[,] arr = makeArray(input);
            int[] results = counterClockspiral(input, arr);
            assertThat(results, expectedResult);
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

            if (result.Length > arr.Length)
            {
                bResult = false;
            }
            else
            {
                for (int i = 0; i < ROW * COLUMN; i++)
                {
                    if (arr[i] == result[i])
                    {
                        bResult = true;
                    }
                    else
                    {
                        bResult = false;
                    }
                    Console.Write(result[i] + " ");
                }
                Console.WriteLine();
            }

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
                    startingColumnIndex = input - (rightToLeftCnt + 1);
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
                    results[cnt] = arr[startingRowIndex, i];
                    cnt++;
                    if (cnt == total)
                        break;
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
                    endingRowIndex = input - upToDownCnt - 1;
                    startingColumnIndex = upToDownCnt;
                }

                // 위에서 아래로 출력한다.
                for (i = startingRowIndex; i <= endingRowIndex; i++)
                {
                    results[cnt] = arr[i, startingColumnIndex];
                    cnt++;
                    if (cnt == total)
                        break;
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
                    endingColumnIndex = input - leftToRightCnt - 1;
                }
                
                // 왼쪽에서 오른쪽으로 출력한다.
                for (i = startingColumnIndex; i <= endingColumnIndex; i++)
                {
                    results[cnt] = arr[startingRowIndex, i];
                    cnt++;
                    if (cnt == total)
                        break;
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
                    results[cnt] = arr[i, endingColumnIndex];
                    cnt++;
                    if (cnt == total)
                        break;
                }
                downToUpCnt++;
            }

            return results;
        }
    }
}
