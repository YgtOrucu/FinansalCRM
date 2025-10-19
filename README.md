# 💼 FinansalCRM Projesi

## 📘 Proje Tanıtımı
FinansalCRM, bireysel veya kurumsal kullanıcıların **banka hesaplarını**, **gelir/gider hareketlerini** ve **harcamalarını** tek bir panelden yönetebilmesini sağlayan bir Windows Forms uygulamasıdır.  
Proje, **Entity Framework (DB First)** yapısı ile SQL veritabanından veri çekilerek geliştirilmiştir.  
Kullanıcı dostu arayüzüyle birlikte tüm temel **CRUD (Create, Read, Update, Delete)** işlemleri gerçekleştirilebilir.

---

## ⚙️ Kullanılan Teknolojiler

- **.NET Framework (C# - Windows Forms)**
- **Entity Framework (DB First)**
- **Microsoft SQL Server**
- **LINQ Sorguları**
- **Chart Control (Grafik Gösterimleri)**
- **Modern UI Tasarımı (Panel ve Kart Yapıları)**


---

## 🧑‍💼 1. Admin Giriş Ekranı (FrmAdmin)

📸 <img width="792" height="446" alt="image" src="https://github.com/user-attachments/assets/c5b66cc5-1c90-4b44-ad5d-94e070bab6a4" />

**Açıklama:**
- Uygulamaya giriş yalnızca kayıtlı admin kullanıcıları tarafından yapılabilir.
- Yanlış bir giriş söz konusu olduğun da kullanıcıya Mesaj verilerek uyarılır.
- Başarılı giriş sonrası ana panele yönlendirme yapılır.

**İşlevler:**
- Kullanıcı doğrulama  
- Giriş sonrası form yönlendirme  
- Hatalı giriş uyarısı

---

## 🏦 2. Bankalar Formu (FrmBanka)

📸 <img width="1098" height="539" alt="image" src="https://github.com/user-attachments/assets/b6cecaee-c89b-4b38-8323-11699888461e" />


**Açıklama:**
Bu formda tüm banka bilgileri listelenir. Her bankanın mevcut bakiyesi kart formatında görüntülenir.  
Ayrıca sol menüden farklı formlara erişim sağlanabilir.

**Ek Özellikler:**
- Kart yapısında her bankanın güncel bakiyesini gösterir.  
- Son 5 banka hareketini özet olarak ekranda görüntüler.

---

## 💸 3. Gelir / Gider Formu (FrmGelirGider)

📸 <img width="1102" height="728" alt="image" src="https://github.com/user-attachments/assets/8abff77f-8fc2-4243-8e60-14b989bb3b8f" />


**Açıklama:**
Gelir ve gider hareketlerinin filtrelenip analiz edilebildiği alandır.  
Formun üst kısmında filtre alanı, alt kısmında ise istatistik grafikleri yer alır.

**İşlevler:**
- 🔍 **Filtreleme:**  
  - Gelir/Gider türüne göre  
  - Bankaya göre  
  - Tarih aralığına göre  

- 💰 **Toplam Hesaplama:**  
  - Toplam gelen havale  
  - Toplam giden havale  
  - Net bakiye  

- 📊 **Grafik Gösterimi:**  
  - Chart component ile aylık gelir/gider analizi  

- ⚙️ **CRUD İşlemleri:**  
  - Yeni gelir/gider kaydı ekleme  
  - Mevcut kaydı düzenleme  
  - Kaydı silme  
  - Tüm işlemleri listeleme  

---

## 💰 4. Harcamalar Formu (FrmHarcamalar)

📸 <img width="1104" height="544" alt="image" src="https://github.com/user-attachments/assets/f51c8c44-f787-4f8d-ac7a-a0b7e94cafab" />


**Açıklama:**
Bu form, harcamaların kayıt altına alındığı bölümdür.  
Her harcama bir kategoriye bağlı olarak kaydedilir.

**İşlevler:**
- Yeni harcama ekleme  
- Harcama bilgilerini güncelleme  
- Harcama silme  
- Tüm harcamaları listeleme  
- Kategori bazlı raporlama yapılabilir.

---

## 🗂️ 5. Kategoriler Formu (FrmKategoriler)

📸 <img width="1104" height="533" alt="image" src="https://github.com/user-attachments/assets/67d5386a-1355-49c8-b78b-685d1daa6dd0" />


**Açıklama:**
Bu form, Kategorilerin kayıt altına alındığı bölümdür. 

**İşlevler:**
- Kategori ekleme  
- Kategori silme  
- Kategori güncelleme  
- Kategori listeleme  

---

## 🔄 6. Banka Hareketleri Formu (FrmBankaHareketleri)

📸 <img width="1241" height="686" alt="image" src="https://github.com/user-attachments/assets/3336362f-bb84-414f-a6c1-1593d0c16021" />


**Açıklama:**
Her Bankaya ait gelen ve giden transferler bu form da gösterilir.
Son 5 banka hareketi ayrıca ana panelde özet olarak gösterilir.

**İşlevler:**
- Bankalar arası transfer kaydı oluşturma  
- Hareket düzenleme  
- Hareket silme
- Hareket listeleme 
- Tüm hareketleri listeleme

**Ek Özellikler:**
- CRUD işlemleri dışında tarihe,işlem türüne ve bankaya göre Listeleme işlemi yapılır.

---

## 📈 7. İstatistik Formu (Frmİstatistik)

📸 <img width="1307" height="744" alt="image" src="https://github.com/user-attachments/assets/c24c5b99-ac9f-4349-8aec-11e3200f468f" />

---


## ✅ Sonuç

Bu proje, **Entity Framework DB First** mimarisiyle geliştirilmiş modern bir **Finansal CRM** uygulamasıdır.  
Kullanıcılar tüm banka ve finansal hareketlerini tek bir noktadan yönetebilir, analiz edebilir ve raporlayabilir.  

🔹 Kullanıcı dostu arayüz  
🔹 Esnek filtreleme ve raporlama  
🔹 Dinamik veri bağlantısı  
🔹 CRUD işlemleri ile tam yönetim kontrolü  

---
