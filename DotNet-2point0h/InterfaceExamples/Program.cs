using InterfaceExamples.Models;
using InterfaceExamples.Interfaces;

iPhone phoneA = new iPhone {
                    Brand = "Apple", 
                    Model = "iPhone 11"
                };
Android phoneB = new Android {
            Brand = "Google", 
            Model = "Samsung Galaxy 23"
        };

iPhone phoneC = new iPhone {
            Brand = "Apple", 
            Model = "iPhone 8"
        };
Android phoneD = new Android {
            Brand = "Google", 
            Model = "Samsung Galaxy 12"
        };

ListLecture<ISmartphone> smartphones = new List<ISmartphone>{
    phoneA,
    phoneB,
    phoneC,
    phoneD

};

foreach(ISmartphone phone in smartphones){
    phone.BrowseInternet();
};