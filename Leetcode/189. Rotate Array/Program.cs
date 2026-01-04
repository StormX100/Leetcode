/*
 * Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
 * */

var rotateArray = new RotateArray();
rotateArray.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3); // 5,6,7,1,2,3,4
rotateArray.Rotate(new int[] { -1, -100, 3, 99 }, 2); // 3,99,-1,-100

public class RotateArray
{
    public void Rotate(int[] numbers, int steps)
    {
        if (steps > numbers.Length)
        {
            steps = steps % numbers.Length;
        }

        numbers = numbers.Skip(numbers.Length - steps).Concat(numbers.Take(numbers.Length - steps)).ToArray();
        DisplayNumbers(numbers);
    }

    private void DisplayNumbers(int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}