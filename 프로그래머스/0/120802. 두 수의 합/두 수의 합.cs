using System;

public class Solution 
{
    public int solution(int num1, int num2) 
    {
        int answer = num1 + num2;

        return answer;
    }

    public void Main(string[] args)
    {
        int answer;

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        answer = solution(num1, num2);

        Console.WriteLine(answer);

    }
}