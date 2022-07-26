namespace MyClassesTest;

public class User {
    public string name;

    public User(string name) {
        this.name = name;
    }
}

public class Student : User {
    public Student(string name) : base(name) 
    {}
}

public class Car {
    public int year;

    public Car(int year) {
        this.year = year;
    }
}