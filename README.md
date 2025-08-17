# Basic MVC Projesi

Bu proje, ASP.NET Core MVC kullanarak müşteri ve sipariş bilgilerini görüntülemek için geliştirilmiş basit bir uygulamadır.

## Proje Yapısı

- **Models/**: Veri modellerini içerir
  - `Customer.cs`: Müşteri model sınıfı
  - `Order.cs`: Sipariş model sınıfı

- **ViewModels/**: View model sınıflarını içerir
  - `CustomerOrderViewModel.cs`: Müşteri ve sipariş verilerini bir arada tutan view model

- **Controllers/**: Controller sınıflarını içerir
  - `CustomerOrdersController.cs`: Müşteri ve sipariş işlemlerini yöneten controller

- **Views/CustomerOrders/**: View dosyalarını içerir
  - `Index.cshtml`: Müşteri ve sipariş bilgilerini gösteren ana sayfa

## Uygulamayı Çalıştırma

1. Terminal'de proje klasörüne gidin:
   ```bash
   cd BasicMVC
   ```

2. Uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```

3. Tarayıcınızda aşağıdaki adrese gidin:
   ```
   https://localhost:5001/CustomerOrders
   ```
   veya
   ```
   http://localhost:5000/CustomerOrders
   ```

## Özellikler

- ✅ Müşteri bilgilerini görüntüleme (ID, Ad, Soyad, E-posta)
- ✅ Sipariş listesini tablo halinde görüntüleme
- ✅ Her sipariş için toplam fiyat hesaplama
- ✅ Genel toplam hesaplama
- ✅ Modern ve responsive tasarım
- ✅ MVC mimarisi kullanımı

## Teknolojiler

- ASP.NET Core 8.0
- MVC Pattern
- C#
- HTML/CSS 