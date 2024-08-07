using PatikaWeek4PracticeInheritance;

Ogrenci student = new Ogrenci(); // Creating an instance for Ogrenci

// Settting properties of Ogrenci
student.Ad = "Bilal";
student.Soyad = "Bilin";
student.StudentNumber = 2174112;

student.DisplayFullNameAndNumber(); // Calling the method that display full name and student number

Ogretmen teacher = new Ogretmen(); // Creating an instance for Ogretmen

// Setting properties of Ogretmen
teacher.Ad = "Disa";
teacher.Soyad = "Dilan";
teacher.Salary = 17002;

teacher.DisplayFullNameAndSalary(); // Calling the method that display full name and salary