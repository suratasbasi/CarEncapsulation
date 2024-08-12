# Encapsulation

## Proje Özeti

Bu proje, `Car` sınıfı ile bir arabanın marka, model, renk ve kapı sayısı gibi bilgilerini tutan temel bir C# uygulamasıdır. `NumberOfDoors` özelliği, yalnızca 2 veya 4 değerlerini kabul edecek şekilde doğrulanır. Geçersiz bir değer girildiğinde, özellik -1 olarak ayarlanır ve uygun bir uyarı mesajı konsola yazdırılır. `CarInformation` metodu, arabanın tüm bilgilerini ekrana yazdırır.

## Nasıl Çalıştırılır

1. **Proje Dosyalarını İndirin:** Proje dosyalarını bilgisayarınıza indirin veya klonlayın.
2. **Visual Studio veya VS Code Açın:** Proje dosyalarınızı Visual Studio veya VS Code gibi bir IDE'de açın.
3. **Projeyi Derleyin ve Çalıştırın:**
   - **Visual Studio:** Çözüm Yöneticisi'nde projeyi seçin ve `Ctrl + F5` tuşlarına basarak çalıştırın.
   - **VS Code:** Terminali açın ve `dotnet run` komutunu çalıştırarak projeyi başlatın.

## Kullanılan Teknolojiler

- **C#:** Projede C# programlama dili kullanılmıştır.
- **.NET Framework / .NET Core:** Proje, C# dilini destekleyen .NET Framework veya .NET Core üzerinde çalışmaktadır.
- **Visual Studio / VS Code:** Proje geliştirilirken Visual Studio veya VS Code IDE'leri kullanılmıştır.

## Ekstra Bilgiler

- **`Car` Sınıfı:**
  - **Parametreli Constructor:** Marka, model, renk ve kapı sayısı bilgilerini alarak yeni bir araba nesnesi oluşturur.
  - **`NumberOfDoors` Özelliği:** Kapı sayısının geçerli olup olmadığını kontrol eder ve gerekirse -1 olarak ayarlar.
  - **`CarInformation` Metodu:** Araba bilgilerini ekrana yazdırır.
