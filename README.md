Console_GitTest

## windows ##
## git --help => kullanılabilecek olan git komutlarını indirir

## vs'da örneğin class'a sağ tıklayıp Git => Compare With UnModified dediğimizde commit etmeden hemen önceki halini görmüş oluruz.
![image](https://user-images.githubusercontent.com/17858773/206699927-3cef12ae-c7e6-437f-8e5e-8b019f60a6b9.png)

## class'a sağ tık Git => Undo changes dediğimizde bir önceki değişikliğe geri döner , COMMIT öncesi tabi

## class'a sağ tık Git => Blame (Annotation) tıklandığında dosyadaki her satır kümesinin hangi commit ile eklendiği ve kimin tarafından ne zaman eklendiği bilgilerini gösterir
 
## eğer new branch denirse o anki görüntü yeni branch e aktarılır. yeni branch te yapılacak değişiklikler diğerini etkilemez. Örneğin test branch i açtık ve orada değişiklikleri yaptık, çalışıyor uygulama, böylece canlı ortam branch ine aktarılabilir gibi,

github üzerinden aşağıdaki gibi değiştirerek kodlar arası versiyon geçişinde bulunabilir.

![image](https://user-images.githubusercontent.com/17858773/207017992-2115a707-3714-44f3-99b8-8e38981d3e35.png)

Visual studio da ise aşağıdaki gibi değiştirilebiliyor.

![image](https://user-images.githubusercontent.com/17858773/207018519-ac5f1324-0b97-4c6f-a383-5551961447bb.png)

## eğer yeni bir geliştirmeyi commitlemeden önce stage e alırsak, buna tüm branch ler erişebilir. Commitlenene kadar da aktif olur.

## örneğin bir dosyada ard arda birçok değişiklik yapıldı ama commit lenmedi ama save ile kaydedildi. Bu durumda bir önceki commit e dönmek için
git restore dosyadi.cs ile eski haline geri dönülür
ya da

git checkout <commitid> ile istenilen commit e geri dönülür ya da vs de aşağıdaki gibi sağ tık checkout ile bir önceki versiyona geri dönülür
 
 ![image](https://user-images.githubusercontent.com/17858773/207597131-12f0f37f-1dfe-4a62-9394-32b7dd9c2c28.png)

