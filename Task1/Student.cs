public class Student : Person
{
    public override string Great()
    {
        return $"Hello!";
    }

    public string Study()
    {
        return $"I'm studying";
    }

    public string ShowAge()
    {
        return $"My age is: {Age} years old";
    }
}