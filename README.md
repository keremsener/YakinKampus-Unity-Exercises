# 🎮 Yakın Kampüs - Unity Eğitim Serisi Projesi

Bu depo, Yakın Kampüs'ün Unity eğitim serisi takip edilerek geliştirilen, C# ve Unity oyun motoru temellerini içeren alıştırma projesidir. Eğitim süresince öğrenilen mekanikler, kod yapıları ve problem çözümleri burada uygulanmıştır.

## 🎯 Kazanımlar (Neler Öğrendim?)

Bu projenin geliştirilme sürecinde aşağıdaki temel oyun geliştirme konseptlerini öğrendim ve uyguladım:

### 1. Unity Arayüzü ve Fizik Motoru
* **Scene & Game View:** Sahne yönetimi ve oyun içi kamera yerleşimi.
* **Rigidbody & Colliders:** Yerçekimi, çarpışma (Collision) ve içinden geçilebilir alanlar (Trigger) mantığı.
* **Prefab Mantığı:** Tekrar kullanılabilir objeler oluşturma.

### 2. C# ile Scripting ve Hareket Mekaniği
* **Transform Manipülasyonu:** `Vector3` kullanarak objeleri 3D uzayda hareket ettirme.
* **Time.deltaTime:** Oyunun her bilgisayarda (FPS fark etmeksizin) aynı hızda çalışmasını sağlayan kare hızı bağımsız hareket sistemi.
* **Input Handling:** Kullanıcıdan klavye girdisi alma (`Input.GetKey`).
    * *Not:* Unity'nin Eski (Old) ve Yeni (New) Input sistemlerinin çakışması (`Both` ayarı ile) çözüldü.

### 3. Etkileşim ve Oyun Mantığı (Game Logic)
* **Trigger Events:** `OnTriggerEnter` kullanarak objeler arası etkileşim (Örn: Altın toplama).
* **Tag Sistemi:** `CompareTag("Player")` ile çarpışılan objeyi ayırt etme.
* **Debugging:** `Debug.Log` ile konsol takibi ve hata ayıklama.
* **Object Lifecycle:** `Destroy(gameObject)` ile toplanan objelerin sahneden silinmesi.

### 4. Problem Çözme & Optimizasyon 🛠️
* **Sonsuz Döngü Hatası:** `Update` fonksiyonu içinde `while` döngüsü kullanmanın Unity'yi kilitlemesi (Crash) tecrübe edildi ve mantık `if` blokları ile düzeltildi.
* **Koşma Mekaniği:** Hızın sürekli katlanarak artması (Exponential) hatası, sabit hız ataması yapılarak düzeltildi.

## 📂 Proje İçeriği
* **Hareket Sistemi:** `W, A, S, D` veya Yön Tuşları ile hareket.
* **Koşma:** `Sol Shift` tuşuna basılı tutarak hızlanma.
* **Toplanabilir Objeler:** Oyuncunun temas ettiğinde yok olan ve puan kazandıran küpler.

## 🚀 Kurulum

Bu projeyi kendi bilgisayarınızda incelemek için:

1.  Bu depoyu klonlayın:
    ```bash
    git clone [https://github.com/keremsener/YakinKampus-Unity-Exercises.git](https://github.com/keremsener/YakinKampus-Unity-Exercises.git)
    ```
2.  Unity Hub'ı açın ve **Add** butonuna basarak klasörü seçin.
3.  Proje **Unity 6 (6000.x)** sürümü ile oluşturulmuştur.

---
*Bu proje, öğrenme amaçlı geliştirilmeye devam etmektedir.*
