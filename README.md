# 27-06-2024-Full-Stack-Bootcamp-Third-Backend-Project

dotnet new list
dotnet new mvc -o DBTechcareer -f net8.0
EF - ORM

Design Package: Migrations (Veritabanı Geçişleri) Yönetimi saglar. dotnet ef migrations add [MigrationName] komutu ile yeni bir veritabanı geçişi oluşturmak icin Design paketine ihtiyac var.

Olusturdugumuz classlari/entityleri sql de tabloya cevirmek icin DBcontext olusturduk. Classlari alip DB ye set ettik.

CodeFirst: Entity classlarimizla is yapmamiz. 

1)Projeyi olustur
2)SqlLite kur.
3)Design Paketi kur.
4)Data klasorü ac. Modelleri olustur. (Modelleri Model klasörünün icine de olusturabilirim)
5)DbContext i olustur.
6)Program.cs te build edilmeden onceye connection string tanimla. GetConnectionString("database"); //adini database yazmak zorundayiz.
7)

appsettings.Development.json: Deneme yapilirken connectionstring buraya yazilir.
appsettings.json: Canliya alinacagi zaman buraya yazilir.

