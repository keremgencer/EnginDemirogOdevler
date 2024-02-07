using Business.Concrete;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(new Entities.Concrete.Person() { FirstName = "isim", LastName = "soyisim", DateOfBirthYear = 2024, NationalIdentity = 12345678905 });