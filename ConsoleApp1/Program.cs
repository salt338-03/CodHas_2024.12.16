
// 배열 선언
using System;

string[] ArrayPractice = new string[10];

ArrayPractice[0] = "동해 물과 백두산이".IndexOf("백두산이").ToString();
ArrayPractice[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
ArrayPractice[2] = "질서 있는 퇴장".Contains("퇴").ToString();
ArrayPractice[3] = "그 사람의 그림자는 그랬다".Replace("그","이").ToString();
ArrayPractice[4] = "삼성 갤럭시".Insert(3,"애플").ToString();
ArrayPractice[5] = "오늘은 왠지 더 배고프다".Remove(7,1).ToString();
string[] input = "이름, 나이, 전화번호".Split(',');
ArrayPractice[6] = input[0];
ArrayPractice[7] = input[1];
ArrayPractice[8] = input[2];
ArrayPractice[9] = "우리 나라 만세".Substring(3, 2);



//출력
for (int i = 0; i < ArrayPractice.Length; i++)
{
    Console.WriteLine($"ArrayPractice[{i}] = {ArrayPractice[i]}");
}

