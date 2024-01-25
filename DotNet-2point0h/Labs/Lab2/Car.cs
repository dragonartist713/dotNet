//=================Imports============================
//================Properties==========================

public int Wheels { get; set; }
public int Speed { get; set; }
public Person?[] Passengers { get; set; }
public int TotalSeats { get; set; }
public Person? Driver { get; set; }

//================Methods==========================

public void Car(int wheels){
    this.Wheels = wheels;
    this.TotalSeats = 4;
    this.Passengers = new Person[4];
}
public void Car(int wheels, int totAvailSeats){
    this.Wheels = wheels
    this.TotalSeats = totAvailSeats
    this.Passengers = new Person[totAvailSeats];
}
public bool AddPassenger(Person person){
    bool addedPerson = false
    if (NumAvailSeats() > 0){
        //check if person is in the car
        if(!CheckPassenger(person.firstName, person.lastName)){
            //add person if not
            for(int i = 0; i < this.Passengers.length; i++){
                if(this.Passengers[i] == null){
                    this.Passengers[i] = person
                    addedPerson = true;
                    break;
                }
            }
            
        }else{
            Console.WriteLine($"{person.FirstName} {person.LastName} is already in this car.")
        }
    }
    return addedPerson;
}
public void RemovePassenger(Person person){
    if()
}
public bool CheckPassenger(string firstName, string lastName){
    for(int i = 0; i < this.Passengers.length; i++){
        if(this.Passengers[i].FirstName == this.firstName && this.Passengers[i].LastName == this.lastName){
            return true
        }
    }
    return false
}
public void AssignDriver(Person person){
    curDriver = this.Driver

}
public void NumAvailSeats(){
    int availSeats = 0
    for(int i = 0; i < this.Passengers.length; i++){
        if(this.Passengers[i] == null){
            availSeats += 1
        }
    }
    return availSeats
}