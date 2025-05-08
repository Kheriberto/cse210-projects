using System;
class Program
{
    static void Main(string[] args)
    {
        int score;
        int residualScore;
        string grade;
        string gradeSign;
        string gradeLetterSign;

        Console.Write("What is the score? ");
        score = int.Parse(Console.ReadLine());

        if (score >= 90)
            {
                grade = "A";
            }
        else if (score < 90 && score >= 80)
            {
                grade = "B";
            }
        else if (score < 80 && score >= 70)
            {
                grade = "C";
            }
        else if (score < 70 && score >= 60)
            {
                grade = "D";
            }
        else
            {
                grade = "F";
            }

        if (grade != "F")
            {
                residualScore = score % 10;

                if (grade == "A" && score >= 97)
                    {
                        gradeSign = "";
                    }
                else if (residualScore >= 7)
                    {
                        gradeSign = "+";
                    }
                else if (residualScore >= 3 && residualScore < 7)
                    {
                        gradeSign = "-";
                    }
                else
                    {
                        gradeSign = "";
                    }
            }
        else
            {
                gradeSign = "";
            }

        gradeLetterSign = grade + gradeSign;
        
        Console.WriteLine($"The letter grade for score {score} is: {gradeLetterSign}");
        Console.WriteLine();
    }
}