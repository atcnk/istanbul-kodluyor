/* http, https
 * 
 * http -> kopru metni aktarim protokolu. istemci ve sunucu arasindaki iletisim icin kullanilan bir protokoldur. iletisim kurallari kumesidir.
 * biz bir http istegi gonderiyoruz ve web sunucusu bize http yaniti ile karsilik veriyor.
 * https -> kopru metni aktarim protokolu guvenli. https'de tarayici ve sunucu veri aktarimina baslamadan once guvenli ve sifreli bir baglanti kuruyor.
 */

/* http request anatomisi
 * 
 * bi adrese gitmek istedigimiz zaman http request yani istek olusturulur ve sunuculara iletilir.
 * get, post, put, delete bazi request moetotlaridir.
 * get: veri listelemek veya goruntulemek icin kullanilir.
 * post: veri eklemek icin kullanilir.
 * put: verinin guncellenmesi icin kullanilir.
 * delete: veri silmek icin kullanilir.
 * alan adi sonrasi genel request path kismi oluyor, '/' sonrasi kisim. 
 * request herader bi kullanicinin web sitesine erismesini sagliyor.
 * kullanici bi siteye erismek istediginde http request header olusturuluyor ve sunucuya gonderiliyor.
 * bu header icerisinde kaynak ip adresi, istenen url, host, tarayicinin kabul edecegi veri turu gibi bilgiler tutuluyor.
 * request body kisminda gonderilen istek ile sunucuda yapilmak istenen degisiklikle alakali datalar aktarilir.
 * butun http isteklerinde body bolumu dolu olarak hedef sunucuya gonderilmez.
 * get, head, delete gibi isteklerde sunucuya herhangi bi data gitmediginden dolayi body bolumune ihtiyac duyulmaz.
 */

/* http response anatomisi
 * 
 * http response, istemcinin gonderdigi http istegine cevap olarak sunucudan aldigi yanittir. yanit icerisinde birden fazla bilesen vardir.
 * http yanit satiri -> http/1.1 OK bolumu
 * http protokolunun versiyon 
 * http yanit kodu -> http status code, 200 404 vb
 * http yanit kodu mesaji
 * http yanit basliklari, istek basliklarina benzer
 * duruma bagli olarak istek gonderilen kaynaga yonelik data iceren http govdesi -> http response body
 */

/* http resquest methodlari
 * 
 * get: sunucudan veri almak icin kullanilir. 
 * post: sunucuya veri yazdirmak icin kullanilir.
 * put: servis saglayici uzerindeki bi kaynagi guncelleyebilirsiniz.
 * head: get ile benzr ancak geri donen yanitta mesaj govdesi bulunmaz.
 * delete: sunucudaki herhangi bi veriyi silmek icin kullanilir.
 * connect: istenen kaynakla iki yonlu bir iletisim (tunel) baslatmak icin kullanilir.
 * options: belli bir kaynak icin kullanilabilecek http metodlarini sunucudan sorgulamak icin kullanilir.
 * trace: hedef kaynak icin yolu test eden bi mesaj geri dongu testi gerceklestirmek icin kullanilir.
 * patch: kaynaga istedigin kucuk capli bi degisim yapmamizi sagliyor.
 * search: bir dizinin altindaki kaynaklari sorgulamak icin kullanilir.
 */

/* http response status codes
 * 
 * 200: ideal veya basarili.
 * 301: kalici yonlendirme, giren kullanici baska bi web sayfasina otomatik olarak yonlendirilir.
 * 302: gecici yonlendirme. kullanici farki anlamaz 301 ile ama bakim gibi gecici durumlar icin kullanilir.
 * 403: erisim izni sorunu.
 * 404: bulunamadi. goruntulenmek istenen web sitesiyle alakali sunucuda bulunmadigini ifade eder.
 * 410: kalici olarak bulunamadi. kalici olarak silindi ve geri gelmeyecegini ifade eder.
 * 500: sunucuda bir seylerin ters gittigini ifade eder.
 * 503: sunucuda sorun oldugunu ifade eder, sunucu kullanilamiyor hatasi. bakim zamani veya asiri yuklenme gibi.
 */