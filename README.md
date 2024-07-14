# 27-06-2024-Full-Stack-Bootcamp-Third-Backend-Project

dotnet new list
dotnet new mvc -o DBTechcareer -f net8.0
EF - ORM

Design Package: Migrations (Veritabanı Geçişleri) Yönetimi saglar. dotnet ef migrations add [MigrationName] komutu ile yeni bir veritabanı geçişi oluşturmak icin Design paketine ihtiyac var.

Olusturdugumuz classlari/entityleri sql de tabloya cevirmek icin DBcontext olusturduk. Classlari alip DB ye set ettik.

CodeFirst: Entity classlarimizla is yapmamiz. 

1)Projeyi olustur
2)SqlLite kur.
3)Tool paketi yükle.
4)Design Paketi kur.
5)Data klasorü ac. Modelleri olustur. (Modelleri Model klasörünün icine de olusturabilirim)
6)DbContext i olustur.
7)Program.cs te build edilmeden onceye connection string tanimla. GetConnectionString("database"); //adini database yazmak zorundayiz.
)Migration yap.

appsettings.Development.json: Deneme yapilirken connectionstring buraya yazilir.
appsettings.json: Canliya alinacagi zaman buraya yazilir.

Migration: Veritabani semasini olusturur.

dotnet tool list 
dotnet tool install --global dotnet-ef --version 7.0.8  //buradaki -g globale kaydet demek.

Migration olusturmak icin; dotnet ef migrations add MigrationName




