Türkçe ve İngilizce

## **TÜRKÇE**

Bu Windows form uygulaması ORM olan Entity Framework için veri tabanını yöneten Migration mantığını düzenleyen bir araçtır. 
Migration veri tabanını yönetir çünkü veri tabanı oluşturmadan tutup tablo ekleme çıkartma aynı şekilde kolon ve kolon tipleri gibi veri tabanında tüm ekleme çıkartma ve düzenleme işlemleri yapılmaktadır. Bu kayıtlar __MigrationHistory tablosunda saklanır ve varbinary(MAX) şeklinde saklanmaktadır. Entity Framework bu tablosundaki dan migrationları okuyarak veri tabanında yapacağı değişiklikleri bularak işlemlerini gerçekleştirir. 

Migration Editor __MigrationHistory tablosundaki varbinary(MAX) tipindeki yani C# karşılığı byte[] tipindeki verileri okunabilir hale getirir, düzenleme ye izin vererek bu verilerin güncellenmesini sağlar.

**Neden Migration Editor'e ihtiyaç duyarım? 🙄**

 - Gönderdiğimiz migration beklemediğimiz şekilde aksiyon almadığı durumlarda migration içerini görüntüleyebilmek
 - Projenin namespace adresi değiştiğinde beklenmedik migration hataları alındığında migration düzenleyebilmek.

## ENGLISH
