using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public double MathScore { get; set; }
    public double PhysicsScore { get; set; }
    public double ChemistryScore { get; set; }
    public double AverageScore { get; set; }
    public string AcademicPerformance { get; set; }

    public void CalculateAverageScore()
    {
        AverageScore = (MathScore + PhysicsScore + ChemistryScore) / 3;
    }

    public void CalculateAcademicPerformance()
    {
        if (AverageScore >= 8)
            AcademicPerformance = "Giỏi";
        else if (AverageScore >= 6.5)
            AcademicPerformance = "Khá";
        else if (AverageScore >= 5)
            AcademicPerformance = "Trung Bình";
        else
            AcademicPerformance = "Yếu";
    }
}

