using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20230619_Poker
{
    public class Card
    {
        int playerScore = 0;

        const int RoyalStraightFlush = 26;
        const int BackStraightFlush = 25;
        const int StraightFlush = 24;
        const int FourofaKind = 23;
        const int FullHouse = 22;
        const int Flush = 21;
        const int Mountain = 20;
        const int BackStraight = 19;
        const int Straight = 18;
        const int ThreeofaKind = 17;
        const int TwoPair = 16;
        const int OnePair = 15;
        //const int A = 14;  보류
        const int K = 13;
        const int Q = 12;
        const int J = 11;

        public void PokerCardGame()
        {
   
            char[] suit = { '◆', '♣', '♥', '♠' };  //문양
            char[] value = { 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };


            int[] numbers = new int[52];
            for (int i = 0; i < 52; i++)
            {
                numbers[i] = i + 1;
            }


            Random random = new Random();


            int random1 = random.Next(52) + 1;
            int randomCard1 = numbers[random1];
            int PokerCard1 = randomCard1 / 13;
            int PokerCardNumber1 = randomCard1 % 13;

            int random2 = random.Next(52);
            int randomCard2 = numbers[random2];
            int PokerCard2 = randomCard2 / 13;
            int PokerCardNumber2 = randomCard2 % 13;

            int random3 = random.Next(52);
            int randomCard3 = numbers[random3];
            int PokerCard3 = randomCard3 / 13;
            int PokerCardNumber3 = randomCard3 % 13;

            int random4 = random.Next(52);
            int randomCard4 = numbers[random4];
            int PokerCard4 = randomCard4 / 13;
            int PokerCardNumber4 = randomCard4 % 13;

            int random5 = random.Next(52);
            int randomCard5 = numbers[random5];
            int PokerCard5 = randomCard5 / 13;
            int PokerCardNumber5 = randomCard5 % 13;

            int random6 = random.Next(52);
            int randomCard6 = numbers[random6];
            int PokerCard6 = randomCard6 / 13;
            int PokerCardNumber6 = randomCard6 % 13;

            int random7 = random.Next(52);
            int randomCard7 = numbers[random7];
            int PokerCard7 = randomCard7 / 13;
            int PokerCardNumber7 = randomCard7 % 13;


            Console.WriteLine("컴퓨터 카드: {0} {1}, {2} {3}, {4} {5}, {6} {7}, {8} {9}, {10} {11}, {12} {13}", suit[PokerCard1], value[PokerCardNumber1], suit[PokerCard2], value[PokerCardNumber2],
                suit[PokerCard3], value[PokerCardNumber3], suit[PokerCard4], value[PokerCardNumber4], suit[PokerCard5], value[PokerCardNumber5],
                suit[PokerCard6], value[PokerCardNumber6], suit[PokerCard7], value[PokerCardNumber7]);

            Console.WriteLine("점수 배팅: ");
            int bet = Convert.ToInt32(Console.ReadLine());




            int playerCardNumber = random.Next(52) + 1;
            int playerPokerCard = playerCardNumber / 13;
            int playerPokerCardNumber = playerCardNumber % 13;

            int playerCardNumber2 = random.Next(52) + 1;
            int playerPokerCard2 = playerCardNumber2 / 13;
            int playerPokerCardNumber2 = playerCardNumber2 % 13;

            int playerCardNumber3 = random.Next(52) + 1;
            int playerPokerCard3 = playerCardNumber3 / 13;
            int playerPokerCardNumber3 = playerCardNumber3 % 13;

            int playerCardNumber4 = random.Next(52) + 1;
            int playerPokerCard4 = playerCardNumber4 / 13;
            int playerPokerCardNumber4 = playerCardNumber4 % 13;

            int playerCardNumber5 = random.Next(52) + 1;
            int playerPokerCard5 = playerCardNumber5 / 13;
            int playerPokerCardNumber5 = playerCardNumber5 % 13;


            Console.WriteLine("내 카드: {0} {1}, {2} {3}, {4} {5}, {6} {7}, {8} {9}", suit[playerPokerCard], value[playerPokerCardNumber], suit[playerPokerCard2], value[playerPokerCardNumber2],
                suit[playerPokerCard3], value[playerPokerCardNumber3], suit[playerPokerCard4], value[playerPokerCardNumber4], suit[playerPokerCard5], value[playerPokerCardNumber5]);


            int playerCardNumber6 = random.Next(52) + 1;
            int playerPokerCard6 = playerCardNumber6 / 13;
            int playerPokerCardNumber6 = playerCardNumber6 % 13;

            int playerCardNumber7 = random.Next(52) + 1;
            int playerPokerCard7 = playerCardNumber7 / 13;
            int playerPokerCardNumber7 = playerCardNumber7 % 13;





            Console.WriteLine("첫번째 카드 변경");
            ConsoleKeyInfo userInput1;
            userInput1 = Console.ReadKey(true);

            if (userInput1.KeyChar == '1')
            {
                Swap(ref playerPokerCard, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber, ref playerPokerCardNumber6);
            }
            else if (userInput1.KeyChar == '2')
            {
                Swap(ref playerPokerCard2, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber2, ref playerPokerCardNumber6);
            }
            else if (userInput1.KeyChar == '3')
            {
                Swap(ref playerPokerCard3, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber3, ref playerPokerCardNumber6);
            }
            else if (userInput1.KeyChar == '4')
            {
                Swap(ref playerPokerCard4, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber4, ref playerPokerCardNumber6);
            }
            else if (userInput1.KeyChar == '5')
            {
                Swap(ref playerPokerCard5, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber5, ref playerPokerCardNumber6);
            }
            else
            {

            }

            Console.WriteLine("내 카드: {0} {1}, {2} {3}, {4} {5}, {6} {7}, {8} {9}", suit[playerPokerCard], value[playerPokerCardNumber],
                suit[playerPokerCard2], value[playerPokerCardNumber2],
                suit[playerPokerCard3], value[playerPokerCardNumber3],
                suit[playerPokerCard4], value[playerPokerCardNumber4],
                suit[playerPokerCard5], value[playerPokerCardNumber5]);



            Console.WriteLine("두번째 카드 변경");
            ConsoleKeyInfo userInput2;
            userInput2 = Console.ReadKey(true);

            if (userInput2.KeyChar == '1')
            {
                Swap(ref playerPokerCard, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber, ref playerPokerCardNumber6);
            }
            else if (userInput2.KeyChar == '2')
            {
                Swap(ref playerPokerCard2, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber2, ref playerPokerCardNumber6);
            }
            else if (userInput2.KeyChar == '3')
            {
                Swap(ref playerPokerCard3, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber3, ref playerPokerCardNumber6);
            }
            else if (userInput2.KeyChar == '4')
            {
                Swap(ref playerPokerCard4, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber4, ref playerPokerCardNumber6);
            }
            else if (userInput2.KeyChar == '5')
            {
                Swap(ref playerPokerCard5, ref playerPokerCard6);
                Swap(ref playerPokerCardNumber5, ref playerPokerCardNumber6);
            }


            Console.WriteLine("내 카드: {0} {1}, {2} {3}, {4} {5}, {6} {7}, {8} {9}", suit[playerPokerCard], value[playerPokerCardNumber],
                        suit[playerPokerCard2], value[playerPokerCardNumber2],
                        suit[playerPokerCard3], value[playerPokerCardNumber3],
                        suit[playerPokerCard4], value[playerPokerCardNumber4],
                        suit[playerPokerCard5], value[playerPokerCardNumber5]);

            //패를 순서대로 정렬(suit 할 필요 없음)
            //플레이어 
            int num1 = playerPokerCardNumber;
            int num2 = playerPokerCardNumber2;
            int num3 = playerPokerCardNumber3;
            int num4 = playerPokerCardNumber4;
            int num5 = playerPokerCardNumber5;

            int[] playerArr = { num1, num2, num3, num4, num5 };

            bubble(ref playerArr);
             num1 = playerArr[0];
             num2 = playerArr[1];
             num3 = playerArr[2];
             num4 = playerArr[3];
             num5 = playerArr[4];

            //컴퓨터
            int num6 = PokerCardNumber1;
            int num7 = PokerCardNumber2;
            int num8 = PokerCardNumber3;
            int num9 = PokerCardNumber4;
            int num10 = PokerCardNumber5;
            int num11 = PokerCardNumber6;
            int num12 = PokerCardNumber7;

            int[] Arr = { num6, num7, num8, num9, num10, num11, num12 };

            bubble(ref Arr);
            num6 = Arr[0];
            num7 = Arr[1];
            num8 = Arr[2];
            num9 = Arr[3];
            num10 = Arr[4];
            num11 = Arr[5];
            num12 = Arr[6];

            //플레이어 조건 
            //문양이 같을 경우
            if (playerPokerCard == playerPokerCard2 && playerPokerCard2 == playerPokerCard3 && playerPokerCard3 == playerPokerCard4
                && playerPokerCard4 == playerPokerCard5)
            {
                //로얄 스트레이트 플러쉬
                if (num1 == 1 && num2 == 10 && num3 == 11 && num4 == 12 && num5 == 13)
                {                                      
                    Console.WriteLine("로얄 스트레이트 플러쉬");
                    playerScore = RoyalStraightFlush;
                }
                //백 스트레이트 플러쉬
                if(num1 == 1 &&  num2 == 2 && num3 == 3 && num4 == 4 && num5 == 5)
                {
                    Console.WriteLine("백 스트레이트 플러쉬");
                    playerScore = BackStraightFlush;
                }
                //스트레이트 플러쉬
                if (num1 + 1 == num2 && num2 + 1 == num3 && num3 + 1 == num4 && num4 + 1 == num5)
                {
                    Console.WriteLine("스트레이트 플러쉬");
                    playerScore = StraightFlush;
                }
                //플러쉬
                else  //나머지니까 굳이 숫자 비교 안해도 됨
                {
                    Console.WriteLine("플러쉬");
                    playerScore = Flush;
                }
 
            }

            //문양이 같지 않을 경우
            //포카드
            if(num1 == num2 && num2 == num3 && num3 == num4 || num2 == num3 && num3 == num4 && num4 == num5)
            {
                Console.WriteLine("포카드");
                playerScore = FourofaKind;
            }
            //풀하우스
            if(num1== num2 && num2 == num3 && num4 == num5 || num1 == num2 && num3 == num4 && num4 == num5)
            {
                Console.WriteLine("풀하우스");
                playerScore = FullHouse;
            }
            //마운틴
            if(num1 == 1 && num2 == 10 && num3 == 11 && num4 == 12 && num5 == 13)
            {
                Console.WriteLine("마운틴");
                playerScore = Mountain;
            }
            //백스트레이트
            if(num1 == 1 && num2 == 2 && num3 == 3 && num4 == 4 && num5 == 5)
            {
                Console.WriteLine("백스트레이트");
                playerScore = BackStraight;
            }
            //스트레이트
            if(num1+1 == num2 && num2+1 == num3 && num3+1 == num4 && num4+1 == num5)
            {
                Console.WriteLine("스트레이트");
                playerScore = Straight;
            }
            //트리플
            if(num1 == num2 && num2 == num3 || num2 == num3 && num3 == num4 || num3 == num4 && num4 == num5)
            {
                Console.WriteLine("트리플");
                playerScore = ThreeofaKind;
            }
            //투페어
            if(num1 == num2 && num3 == num4 || num1 == num2 && num4 == num5 || num2 == num3 && num4 == num5)
            {
                Console.WriteLine("투페어");
                playerScore = TwoPair;
            }
            //원페어
            if(num1 == num2 || num2 == num3 || num3 == num4 || num4 == num5)
            {
                Console.WriteLine("원페어");
                playerScore = OnePair;
            }


            //컴퓨터 조건  7장
            //문양이 같을 경우
            if(PokerCard1 == PokerCard2 && PokerCard2 == PokerCard3 && PokerCard3 == PokerCard4 && 
               PokerCard4 == PokerCard5 && PokerCard5 == PokerCard6 && PokerCard6 == PokerCard7)
            {
                ////로얄 스트레이트 플러쉬
                //if()
                //{
                //    Console.WriteLine("로얄 스트레이트 플러쉬");
                //}
                    
            }


                //if ( > )
                //{
                //    Console.WriteLine("당신이 이겼습니다!");
                //}
                //else if ( < )
                //{
                //    Console.WriteLine("당신이 졌습니다!");
                //}
                //else
                //{
                //    Console.WriteLine("무승부입니다!");
                //}

            Console.WriteLine("게임을 계속하시겠습니까? (Y/N)");
            string choice = Console.ReadLine();

            if (choice.ToUpper() == "Y")
            {
                PokerCardGame();
            }
            else
            {

            }

        }

        public void Swap(ref int index1, ref int index2)
        {
            int temp;
            temp = index1;
            index1 = index2;
            index2 = temp;
        }



        static void bubble(ref int[] arr)
        {
            int n = arr.Length;     //크기


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }
       
    }
}








