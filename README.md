[RentACar.docx](https://github.com/tahsinemreozturk/ReCapProject2/files/15399763/RentACar.docx) Daha detaylı bilgi için bu dosyayı inceleyebilirsiniz.
# E-Ticaret Sitesi Projesi 

Bu proje, Kullanıcıların araç kiralama işlemlerini gerçekleştirebileceği ve kiraladıkları araçları yönetebileceği, aracı şirketlerin de portföylerini güncelleyebileceği bir platform.. Proje, Engin Demiroğ Yazılım Yetiştirici Kursu kapsamında, sürdürülebilir yazılım geliştirme prensiplerine dikkat edilerek .Net Core ve ASP.NET teknolojileri kullanılarak geliştirilmiştir. Bu eğitim sürecinde temiz kod yazımına, Plug and Play (PnP) esnekliğine, SOLID prensiplerine ve OOP (Nesne Yönelimli Programlama) ile AOP (Aspect Yönelimli Programlama) yaklaşımlarının önemine odaklandık ve bu prensipleri uyguladık. Proje, çok katmanlı mimari olacak şekilde tasarlanmış olup, bileşenleri Web API, Business, Core, DataAccess ve Entities katmanlarından oluşmaktadır.

## Proje Mimarisi

- **Web API**: RESTful API servislerini barındırır. Uygulamanın farklı ortamlar ve dış dünya ile iletişimi bu katmanda uygulanır.
- **Business**: İş mantığı bu katmanda yer alır. Kurallar ve iş geliştirme süreçlerinin uygulamaları burada yapılır.
- **Core**: Uygulamanın çekirdek katmanıdır. Genel tanımlar, yardımcı sınıflar ve servisler burada bulunur. Farklı projelerde de kullanılabilmesine dikkat edeilerek tasarlanmıştır.
- **DataAccess**: Veritabanı işlemleri bu katmanda gerçekleştirilir. Entity Framework kullanılarak veri erişim işlemleri burada yapılır. 
- **Entities**: Uygulamanın veri modelleri bu katmanda tanımlanır.

## Kullanılan Teknolojiler

- .Net Core
- ASP.NET
- Entity Framework
- Autofac
- Fluent Validation
- JWT

## Proje Özellikleri

- Rol bazlı yetkilendirme
- Arayüzden gelen verilerin validasyonları
- Jwt bazlı authentication ve authorization
- Cache yönetimi
- Log yönetimi
- Kategori ve Ürünler için Ekleme, Silme, Güncelleme, Okuma gibi CRUD operasyonları.




