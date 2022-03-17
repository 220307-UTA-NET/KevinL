class Person
{
    // Fields - Variables that are part of each instance of a class object. 
    public string name;
    public double height;
    public int age;

    //Constructor -  A method used to initialize instances of the class
    public Person(string PersonName = "Default", double PersonHeight = 69.5, int PersonAge = 36)
    {
        this.name = PersonName;
        this.height = PersonHeight;
        this.age = PersonAge;
    }

    public int GrowUp()
    {
        this.age++;
        return this.age;
    }

    public void Shrink()
    {
        this.height--;
    }
}