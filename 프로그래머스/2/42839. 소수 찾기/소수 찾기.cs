using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string numbers) {
        HashSet<int> allNumbers = new HashSet<int>();
        GenerateNumbers(numbers, "", allNumbers);

        int maxNumber = allNumbers.Max();
        bool[] primeArray = Eratosthenes(maxNumber);

        int primeCount = 0;
        foreach (int number in allNumbers) {
            if (primeArray[number]) {
                primeCount++;
            }
        }

        return primeCount;
    }

    private void GenerateNumbers(string numbers, string current, HashSet<int> allNumbers) {
        if (!string.IsNullOrEmpty(current)) {
            allNumbers.Add(int.Parse(current));
        }

        for (int i = 0; i < numbers.Length; i++) {
            GenerateNumbers(numbers.Remove(i, 1), current + numbers[i], allNumbers);
        }
    }

    private bool[] Eratosthenes(int max) {
        bool[] isPrime = new bool[max + 1];
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false;

        for (int i = 2; i * i <= max; i++) {
            if (isPrime[i]) {
                for (int j = i * i; j <= max; j += i) {
                    isPrime[j] = false;
                }
            }
        }

        return isPrime;
    }
}
