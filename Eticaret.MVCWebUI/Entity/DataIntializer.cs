using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eticaret.MVCWebUI.Entity
{
    public class DataIntializer:DropCreateDatabaseIfModelChanges<DataContext>

    //Intializer(inşilayzır): Başlatıcı demek türkçe.

    /*
     * Kalıtım aldığımız Entity'nin bir sınıfı olan  "DropCreateDatabaseIfModelChanges" modelimiz değiştiğinde oluştursun maksadı ile kullanıldı,
     * bunun yerine "CreateDatabaseIfNotExists"'de kullanılabilirdi.
    
     */
    {
        protected override void Seed(DataContext context)
        {
            //Veri tabanı ilk oluşturulduğunda içeriği boş gelmesin diye fake veriler ile doldurduk.
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){ Ad ="Kamera", Aciklama="Kamera ürünleri" },
                new Kategori(){ Ad ="Bilgisayar", Aciklama="Bilgisayar ürünleri" },
                new Kategori(){ Ad ="Elektronik", Aciklama="Elektronik ürünleri" },
                new Kategori(){ Ad ="Telefon", Aciklama="Telefon ürünleri" },
                new Kategori(){ Ad ="Beyaz Eşya", Aciklama="Beyaz Eşya ürünleri" }
            };



            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){Ad="Canon Eos 1200D 18-55mm DC Profesyonel Dijital Fotoğraf Makinası", Aciklama="ULTRA YÜKSEK GÜÇLÜ ZOOM166x Dynamic Fine Zoom¹ değerine çıkarılabilen ve 24 mm geniş açıdan 2000 mm telefotoya kadar (35 mm biçimi eşdeğeri) kapsam aralığı olan 83x NIKKOR zoom objektifle, çıplak gözle görünmeyen baş döndürücü ayrıntıları yakalayın.", Fiyat=1200, StokMiktar=400, Aktif=true, KategoriId=1, iseAnasayfa =true },
                new Urun(){Ad="Nikon D800 18-105mm DSL Profesyonel Dijital Fotoğraf Makinası", Aciklama="Vahşi yaşama ya da gece gökyüzüne meraklı bir fotoğrafçıysanız, 16 megapiksel COOLPIX P900'ün inanılmaz 83x optik zoom'u çıplak gözle görülemeyen ayrıntıları yakalamanıza olanak tanır. 5,0 duraklamalı Çift Algılamalı Optik VR özelliği bulanıklık azaltmayı daha iyi hale getirirken hızlı AF ve azaltılmış çekim süresi gecikmesi özellikleriyle anında çekim yapın.", Fiyat=2200, StokMiktar=100, Aktif=true, KategoriId=1 },
                new Urun(){Ad="Nikon D610 18-55vr DC Profesyonel Dijital Fotoğraf Makinası", Aciklama="Süper telefoto modunda ayrıntılı durağan görüntüler ve Full HD filmler çekmek için değişken açılı ekran ve dahili elektronik vizörle kompozisyon esnekliğinin tadını çıkarın. Dahili GPS/GLONASS/QZSS desteği çekim konumlarını son derece isabetli bir şekilde belirler ve görüntüler dahili Wi-Fi®¹ ve NFC² desteğiyle anında paylaşılabilir.", Fiyat=4200, StokMiktar=200, Aktif=false, KategoriId=1 },
                new Urun(){Ad="Sony Alpa 200 55-200mm DC Profesyonel Dijital Fotoğraf Makinası", Aciklama="Geniş resim açısı: Geniş resim açısına sahip LCD ekranla yaratıcı kompozisyonlar ve alışılmadık bakış açıları elde etmek kolaydır. Bir hayvanın göz hizasını yakalamak için alçak açıdan veya engeller üzerinden yüksek açıdan çekim yapın.", Fiyat=3100, StokMiktar=300, Aktif=true, KategoriId=1,iseAnasayfa =true },
                new Urun(){Ad="Fujifilm DLSR2 18-135 mm DC Profesyonel Dijital Fotoğraf Makinası", Aciklama="19 Sahne modu: Fotoğraf makineniz çekim koşullarınıza en uygun ayarları önerebilir. Konunuza ve koşullarınıza en uygun sahneyi seçmenizle birlikte fotoğraf makineniz ayarları otomatik olarak optimize eder.", Fiyat=4400, StokMiktar=500, Aktif=true, KategoriId=1 },

                new Urun(){Ad="Vestfrost VF 1268 A+ 300 Lt Çift Kapılı Buzdolabı", Aciklama="Tasarımın boyutları standartları karşılıyor. 1850 mm yüksekliğinde, 700 mm genişlik ve 705 mm derinliğinde olan ürün, 92 kilogram ağırlık ile kolaylıkla taşınarak mutfaklara yerleştirilebiliyor. 2 adet kapı bulunduran, bu sayede dondurucu ve soğutucu alanların ayrı ayrı kontrolüne imkan tanıyan model, buzmatik özelliği ile de dikkat çekiyor. Buzdolabının içindeki alanların verimliliğini azaltan, çıkıntılı tasarım ile dolap yerleşimini zorlaştıran büyük aydınlatma kanalları ve havalandırma sistemleri dolabın tasarımında gizleniyor. Bu sayede rafları daha geniş alan sağlayan ve daha kolay yerleştirilen tasarım, Multi Flow havalandırma ile kapının açık olduğu anlarda ısıyı eşitlemek için hızla çalışıyor. Uzun süre taze kalan yiyeceklerin adresi olan ürün, parlak dekoratif rafları, paslanmaz çelik detayları ve cilalı metal yüzeyi ile çalışkanlığına, fonksiyonelliğine, zarif görünümünü de ekliyor. ", Fiyat=1200, StokMiktar=400, Aktif=true, KategoriId=2 },
                new Urun(){Ad="Samsung RL4323RBASP/TR A++ 473 Lt NoFrost Buzdolabı", Aciklama="Samsung RL4323RBASP/TR fiyatı ile avantaj sunarken enerji tasarruf özelliği ve sessizliğini garanti altına alarak kalitesini evlerinize getiriyor. Sürekli çalışan ve duran sıradan kompresörlerin aksine dijital özelliği ile nem seviyesini ayarlayan, sıcaklığı sabitleyen, dayanıklı aksam ile kompresörün aşınmasını azaltan model, düşük elektrik faturalarını gönül rahatlığı ile bekleyeceğinizi müjdeliyor. Soğutma performansını optimize eden akıllı sensör sistemi ile donanan buzdolabı, mükemmel soğutma ve dondurma için beş ayrı sensör ile hizmet veriyor. Şık mavi LED erkan ile kontrol sağlanırken, kolayca erişilen ayarlar menüsü sıcaklık ayarı ve mod seçimi için rahatlıkla komut alabiliyor. Alışverişlere, mevsimsel tüketimlere bağlı olarak buzdolabındaki yiyecekler değişirken ayarlanabilir raflar da değişen alışkanlıklarınıza uyum sağlıyor. Dört ayrı şekilde ayarlanabilir kapı koruyucu, içecek kutularını farklı yükseklikte ve genişlikteki raflara yerleştirmenize imkan tanıyor. ", Fiyat=2200, StokMiktar=100, Aktif=true, KategoriId=2},
                new Urun(){Ad="Vestel EKO SC250 A+ 250 Lt Statik Buzdolabı", Aciklama="Samsung RL4323RBASP/TR, alttan donduruculu özelliği ile kullanıcılara kolaylık sağlıyor. Soğutucu kısmı üstte olan buzdolabı bu sayede sık kullanılan alana erişim için sürekli eğilip kalkma problemini ortadan kaldırıyor. Net olarak 435 litre hacim bulunduran beyaz eşya, solo kullanım şekline uygun görülüyor. Soğutucu bölümünde 303 litre net hacim sahibi olan elektronik cihaz, 3 soğutucu raf ile yiyeceklerin rahatlıkla depolanmasına yardımcı oluyor. Kullanışlı iç tasarım sayesinde yiyecekler sağlıkla ve güvenle depolanırken, kullanıcılar da ihtiyaçlarını dolap içinde rahatlıkla bularak mutfak işlerini hızlandırıyor. Ev ve iş yerleri için uygun olan buzdolaplarının soğutucu bölümü 0 ile 4, dondurucu kısmı ise -18 derece sıcaklık sağlayarak beklentileri karşılıyor. ", Fiyat=4200, StokMiktar=200, Aktif=false, KategoriId=1 },

                new Urun(){Ad="Samsung UE43MU7000 43inc MU7000 7 Serisi Flat 4K UHD TV", Aciklama="Şık görünümünü inoks rengi tasarımına borçlu olan buzdolabı, Samsung kalitesine yakışan detaylarıyla mutfakları teknoloji ile buluşturuyor. No-frost yani derin dondurucu özelliği ile buz yapmadan ürünleri sağlıkla donduran tasarım, dondurucu bölümünde ise tam 132 litre hacim sağlıyor. Performans yükseltirken tasarruf da vadeden Samsung RL4323RBASP/TR özellikleri arasında enerji verimliliği dikkat çekiyor. A++ enerji sınıfına ait olan cihaz, yılda ortalama 296 kWh elektrik harcıyor. Yalnız 41 dB ses ile çalışan buzdolabı, aktif durumdayken bile ses çıkarmıyor, özellikle geceleri duyulan gürültülü motor sesinden kullanıcıları kurtarıyor. Çevreye de dost olan buzdolabı, geleneksel modellere kıyasla %50 daha az enerji harcıyor. Dijital invertör ile çalışan model, LED aydınlatma sisteminde dahi tasarruftan ödün vermiyor. Yalnız az elektrik harcaması ile değil, daha düşük sera gazı üretimi ile de çevreye uyumluluğunu ispatlayan dolap, saklı kapı menteşesi ile estetik görünümü tamamlıyor. ", Fiyat=3100, StokMiktar=300, Aktif=true, KategoriId=3 },
                new Urun(){Ad="Vestel 40FB5050 40' 102 Ekran Full HD Uydu Alıcılı LED TV", Aciklama="Alışveriş listeniz haftadan haftaya değişebileceğinden, mutfak alışverişinizin kolay ve rahat bir şekilde depolanmasına yardımcı olmak için Samsung buzdolabı dört ayrı şekilde ayarlanabilir kapı koruyucusu ile tasarlanmıştır. Derin koruyucu büyük içecek kutularını ve/veya iki sıralı soda kutularını saklarken koruyucular daha uzun şişeleri saklamak için daha yüksek veya daha alçağa kaydırılabilir.", Fiyat=4400, StokMiktar=500, Aktif=true, KategoriId=3,iseAnasayfa =true },
                new Urun(){Ad="LG 60UJ630V 60' 152 Ekran 4K Uydu Alıcılı Smart LED TV", Aciklama="Alışveriş listeniz haftadan haftaya değişebileceğinden, mutfak alışverişinizin kolay ve rahat bir şekilde depolanmasına yardımcı olmak için Samsung buzdolabı dört ayrı şekilde ayarlanabilir kapı koruyucusu ile tasarlanmıştır. Derin koruyucu büyük içecek kutularını ve/veya iki sıralı soda kutularını saklarken koruyucular daha uzun şişeleri saklamak için daha yüksek veya daha alçağa kaydırılabilir.", Fiyat=4400, StokMiktar=500, Aktif=true, KategoriId=3 },


                new Urun(){Ad="Apple iPhone 6 32 GB (Apple Türkiye Garantili)", Aciklama="Dokunmatik ekranlı akıllı cep telefonları, hemen herkesin cebinde yer almaya devam edip sektöre yön veren markaların ortaya koyduğu ürünler farklı kullanım alanlarının oluşmasına da zemin hazırlıyor. Yazılım desteği ve konforlu kullanımıyla dikkat çeken akıllı cep telefonlarına imza atan Apple, iPhone 6 modelleri ile alanındaki uzmanlığını konuşturuyor. ", Fiyat=1200, StokMiktar=200, Aktif=true, KategoriId=3 },
                new Urun(){Ad="Samsung Galaxy Note 8 64 GB", Aciklama="Bu ürün 2 yıl süre ile ithalatçı firma garantisi altındadır. ‘’İthalatçı Firma Garantili’’ ürünlerde 2 yıl süresince, garanti belgenizde bilgileri yer alan teknik servisten garanti kapsamı dahilinde ücretsiz faydalanabilirsiniz. 2 yıl sonrasında ise, marka ile ilgili yetkinliği bulunan tüm teknik servislerden ücretli bir şekilde faydalanmaya devam edebilirsiniz. Telefonunuzda oluşan herhangi bir arıza durumunda ürünün servis noktalarını öğrenmek için Hepsiburada.com ile irtibata geçebilirsiniz.", Fiyat=2200, StokMiktar=200, Aktif=true, KategoriId=4,iseAnasayfa =true},
                new Urun(){Ad="Xiaomi Mi 6 64 GB 4 GB RAM", Aciklama="İş dünyasının ve profesyonellerin hayatını kolaylaştıran özellikleri beraberinde getiren Note serisi akıllı cep telefonlarıyla ses getiren Samsung, Note 7 modelinin güncellenmiş sürümü olan Samsung Galaxy Note Fan Edition ile dikkat çekiyor. Tasarımından dâhili donanım bileşenlerine kadar birçok ögesiyle Galaxy Note serisinin kendine has yapısını sürdüren Samsung Galaxy Note Fan Edition özellikleri ile öne çıkıyor. .", Fiyat=4200, StokMiktar=120, Aktif=false, KategoriId=4 },
                new Urun(){Ad="Huawei Y7 2018 London 16 GB", Aciklama="Geliştirdiği akıllı cep telefonları sayesinde dünyanın dört bir yanındaki sayısız kullanıcıya ulaşan Huawei, Mate ailesini daha ileriye taşımaya kararlı olduğunu Huawei Mate 10 Lite modelleri ile kanıtlıyor. Tatmin edici donanım özelliklerinin becerikli kameralarla desteklendiği ürün, hâlihazırda kullandığı telefonunu güçlü bir modelle değiştirmek isteyen ancak bunu yaparken bütçesini zorlamaktan kaçınanları memnun ediyor.", Fiyat=3100, StokMiktar=222, Aktif=true, KategoriId=4},
                new Urun(){Ad="Samsung Galaxy J7 Prime", Aciklama="İş dünyasının ve profesyonellerin hayatını kolaylaştıran özellikleri beraberinde getiren Note serisi akıllı cep telefonlarıyla ses getiren Samsung, Note 7 modelinin güncellenmiş sürümü olan Samsung Galaxy Note Fan Edition ile dikkat çekiyor. Tasarımından dâhili donanım bileşenlerine kadar birçok ögesiyle Galaxy Note serisinin kendine has yapısını sürdüren Samsung Galaxy Note Fan Edition özellikleri ile öne çıkıyor.", Fiyat=4400, StokMiktar=321, Aktif=true, KategoriId=4,iseAnasayfa =true }
            };


            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }

            base.Seed(context); 
        }
    }
}