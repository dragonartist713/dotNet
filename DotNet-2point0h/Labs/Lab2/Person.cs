//=================Imports============================

class Person{

    //================Properties==========================
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //=================Methods============================

    public void Person(string firstName, string lastName, int age){
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
    public DriveCar(Car car, int speed){
        if(this == car.Driver){
            
        };
    }
    public void GetInCar(Car car){

    }
    public void GetOutOfCar(Car car){

    }
}