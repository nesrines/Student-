class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Score;
    public bool IsGraduated;
    public string ScoreInfo;

    public Student(string Name, string Surname, string Group, double Score, bool IsGraduated)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Group = Group;
        this.Score = Score;
        this.IsGraduated = IsGraduated;

        if(Score < 0 || Score > 100)
        { ScoreInfo = "(invalid score)"; }

        else if(Score > 80)
        { ScoreInfo = "(can enter the next exam)"; }

        else
        { ScoreInfo = "(can't enter the next exam)"; }
    }

    public string FullName()
    {return Name + " " + Surname;}

    public void GetFullInfo()
    {
        if(IsGraduated)
        { Console.WriteLine($"{FullName()} is graduated, group - {Group}, score = {Score} {ScoreInfo}"); }

        else
        { Console.WriteLine($"{FullName()} is not graduated, group - {Group}, score = {Score} {ScoreInfo}"); }
    }

}
