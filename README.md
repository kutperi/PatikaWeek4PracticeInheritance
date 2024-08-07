# PatikaWeek4PracticeInheritance

Bu proje, C# dilinde nesne yönelimli programlama (OOP) kavramlarını kullanarak bir temel sınıf (`BaseKisi`) ve bu sınıftan türeyen iki alt sınıf (`Ogrenci` ve `Ogretmen`) ile bir uygulama örneği sunar.

## Proje Yapısı

### BaseKisi Sınıfı

`BaseKisi` sınıfı, ad ve soyad bilgilerini tutan temel bir sınıftır. Ayrıca, kişinin tam adını ekrana yazdıran bir metoda sahiptir.

- **Özellikler:**
  - `Ad` (string): Kişinin adı
  - `Soyad` (string): Kişinin soyadı

- **Metodlar:**
  - `DisplayFullName()`: Kişinin tam adını ekrana yazdırır.

### Ogrenci Sınıfı

`Ogrenci` sınıfı, `BaseKisi` sınıfından türetilmiştir ve öğrenci numarası bilgilerini tutar. Öğrenci numarası ve tam ad bilgilerini ekrana yazdıran bir metoda sahiptir.

- **Özellikler:**
  - `StudentNumber` (int): Öğrencinin numarası

- **Metodlar:**
  - `DisplayFullNameAndNumber()`: Kişinin tam adını ve öğrenci numarasını ekrana yazdırır.

### Ogretmen Sınıfı

`Ogretmen` sınıfı, `BaseKisi` sınıfından türetilmiştir ve maaş bilgilerini tutar. Maaş ve tam ad bilgilerini ekrana yazdıran bir metoda sahiptir.

- **Özellikler:**
  - `Salary` (decimal): Öğretmenin maaşı

- **Metodlar:**
  - `DisplayFullNameAndSalary()`: Kişinin tam adını ve maaşını ekrana yazdırır.

## Kullanım

### Örnek Kullanım

```csharp
using PatikaWeek4PracticeInheritance;

// Ogrenci sınıfından bir örnek oluşturuluyor
Ogrenci student = new Ogrenci();
student.Ad = "Bilal";
student.Soyad = "Bilin";
student.StudentNumber = 2174112;
student.DisplayFullNameAndNumber(); // Öğrenci bilgilerini ekrana yazdırır

// Ogretmen sınıfından bir örnek oluşturuluyor
Ogretmen teacher = new Ogretmen();
teacher.Ad = "Disa";
teacher.Soyad = "Dilan";
teacher.Salary = 17002;
teacher.DisplayFullNameAndSalary(); // Öğretmen bilgilerini ekrana yazdırır
