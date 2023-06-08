# Employee Tracker

Bu proje, çalışanların yönetimini sağlamak için bir Web API uygulamasıdır. Bu README.md dosyası, proje hakkında genel bilgileri ve nasıl kullanılacağına dair talimatları içermektedir.

## Kurulum

1. Bu projeyi klonlayın veya indirin.
2. Projenin kök dizininde terminali açın.
3. Aşağıdaki komutu çalıştırarak projenin bağımlılıklarını yükleyin:

dotnet restore


Kullanım

1) Terminalde aşağıdaki komutu çalıştırarak projeyi başlatın:

dotnet run

2) Web API uygulaması başarıyla başladıktan sonra, tarayıcınızda aşağıdaki URL'yi ziyaret edin:

https://localhost:5001/swagger

3) Swagger UI üzerinden API dokümantasyonunu inceleyebilir ve farklı istekleri deneyebilirsiniz.

Proje Yapısı

Startup.cs: Projedeki temel yapılandırmaların ve bağımlılıkların tanımlandığı dosya.

Models/Employee.cs: Çalışan modeli ve özellikleri için sınıf tanımı.

Models/ErrorResponse.cs: Hata yanıtı modeli ve özellikleri için sınıf tanımı.

Controllers/EmployeeController.cs: Çalışanların yönetildiği API isteklerinin işlendiği controller sınıfı.

Controllers/ErrorHandlersController.cs: Hata durumlarına özel işlemlerin yapıldığı controller sınıfı.



Lisans
Bu proje MIT lisansı ile lisanslanmıştır.


Yukarıdaki kod örneği, proje hakkında genel bilgileri, kurulum talimatlarını, kullanım yönergelerini, proje yapısını ve katkıda bulunma sürecini içeren temel bir README.md dosyasıdır. Bu örneği kopyalayarak proje kök dizinine bir README.md dosyası oluşturabilir ve içeriği yapıştırabilirsiniz.

Not: Kod örneği sadece proje yapısını ve temel kullanım bilgilerini içermektedir. Projeyle ilgili daha fazla ayrıntı eklemek veya diğer ilgili dosyalara atıfta bulunmak isterseniz README.md dosyasını özelleştirebilirsiniz.
