public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public virtual string Great()
    {
        return $"Hello!";
    }
    public virtual void SetAge(int age)
    {
        Age = age;
    }
}