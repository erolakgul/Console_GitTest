Console_GitTest

## https://infoheap.com/git-view-diff-for-a-given-commit-id/
## git diff commitId^! : commit id de yapılan değişiklikleri gösterir
   git diff 6e39861e8eaa935e6094cf0eadeaec94b5711840^! gibi
eksiler önceki hali, artılar sonraki halini gösterir
![image](https://github.com/erolakgul/Console_GitTest/assets/17858773/112a5942-d9a7-45c0-8398-7762572a1ae1)

## https://kod5.org/baslica-git-komutlari/

![image](https://user-images.githubusercontent.com/17858773/212527032-bef8ef68-32b1-4bb2-adba-d15d1acc9150.png)

## https://app.patika.dev/courses/frontend-web-gelistirme/git-bash-ile-git-temel-komutlari#:~:text=git%20add,staged%20ortam%C4%B1na%20g%C3%B6ndermek%20i%C3%A7in%20kullan%C4%B1l%C4%B1r.&text=Tek%20seferde%20b%C3%BCt%C3%BCn%20dosyalar%C4%B1%20eklemek,%24%20git%20add%20.

/*package manager console veya git bash ten uygulama dizinine gidip kodlar çalıştırılabilir*/

## git log => tüm commitleri listeler
## git branch => tüm branchleri listeler
## git status => hangi branch te olduğu bilgisini döner
## git checkout commitid => ilgili comitte ki an'a gider
## git checkout master => orjinal hale geri getirir
## git branch newBranch => yeni branch açar
## git checkout newBranch => yeni branch e geçiş yapar
## git push origin newBranch => local de komutla çalıştırıldığında branch i github ta da görülebilir kılar

/**/
## git branch -va => master ve diğer branch lerde yapılan değişiklikleri listeler

## git branch -d newbranch => local branch i kaldırma
# git push -d dataTableTrying
## git push "url veya remote" -d newBranch => uzaktaki branch i kaldırma
# git push origin -d dataTableTrying

## git checkout --track origin/newBranch => github tan ilk defa çekilen (git clone) uygulamamnın diğer branch ini de local e çekmek için kullanılır

/*son olarak yeni açılan branch tekilerin master a alınması*/
## git checkout master  => ile merge ile aktarılacak olan branch seçilir
## git merge newBranch   => ile de yeni branch teki değşikliklerin tamamı master branch ine aktarılmış olur.
## git status ile bakıldığında çakışma olan dosyalar listelenir, eğer sroun yoksa
## git push => ile de master sayfasına aktarılmış değişiklikleri remote tarafına gönderir
/*
çakışma olursa merge sayfası açılır, hangi değişiklik geçerli olacaksa o branch seçilir ve accept merge butonuna tıklanır visual studio da
   en sonda da commit stage sync seçilerek eşleştirmenin tamamlanması sağlanır
*/

## git pull

## git rebase master => bu komutu kullandığımızda örneğin test branch in dayız , master da yapılmış değişiklikleri test branch imize almış oluruz, test branch ini açarken çünkü master dan kopyalamıştık; master da bi değişiklik yapıldığında onu içeri alabilmek için rebase komutunu kullanırız:

/* değişiklikleri vs den github a gönderme */
## git add .                   /*tüm dosyaları gönderir*/
## git add path\to\file.cs     /*sadece file.cs i gönderir*/
## git commit -m "Buraya değişiklikle ilgili açıklayıcı yorumunu yaz"
## git push origin currentBranchName
/*eğer remote ta domainLib branch i yok ise*/
## git push --set-upstream origin domainLib



##  git branch -a To see all local and remote branches
##  git branch -vv Kullanılan yerel veya uzak şubeler, commit id'ler, commit mesajları gibi detaylı bilgileri çalıştırarak görebilirsiniz.

## local ve remote branch ismi değiştirme , master da iken
#git branch -m old-name new-name => eski branch adını yenisi ile update eder
#git push origin :old-name new-name => eski branhc i uzaktan siler yenisini açar
#git push origin -u new-name => yeni branch te trace etmeye başlar

## https://medium.com/nafidurmus/git-son-de%C4%9Fi%C5%9Fiklikleri-commiti-geri-alma-%C3%B6rnekli-f9bc1030f8c4
# git reset --hard commitid komutu ile yazılan commitid ye geri dönülür ve aradaki commit ler gider
# git revert commitid  komutu ile de yeni bir commit oluşturur ve yazdığımız commitid yi geçersiz kılar
********************************************************************************************************************************
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

 ///////////////////// isimlendirme kuralları  ////////////////////////////////

 1. Anlaşılır ve Açıklayıcı Olmalı:
Kısa ama açıklayıcı: Branch ismi mümkün olduğunca kısa olmalı, ancak aynı zamanda amacını açıkça ifade etmelidir.
Kolay anlaşılır: Branch ismini gören herkes, bu branch'in ne amaçla oluşturulduğunu kolayca anlayabilmelidir.

3. Standart İsimlendirme Kuralları:
Feature (Özellik) Branch'leri: Yeni bir özellik eklemek için oluşturulan branch'ler. Örneğin, feature/login, feature/user-registration.
Bugfix (Hata Düzeltme) Branch'leri: Hataları düzeltmek için oluşturulan branch'ler. Örneğin, bugfix/fix-login-issue, bugfix/registration-error.
Hotfix (Acil Düzeltme) Branch'leri: Canlıda acil düzeltme gerektiren durumlar için oluşturulan branch'ler. Örneğin, hotfix/security-patch, hotfix/caching-issue.
Release (Sürüm) Branch'leri: Yayına alınacak sürümler için oluşturulan branch'ler. Örneğin, release/v1.0.0, release/v2.1.0.
Chore (Rutin İşler) Branch'leri: Teknik borçları ödemek veya kod tabanını temizlemek için oluşturulan branch'ler. Örneğin, chore/refactor-auth-module, chore/update-dependencies.

5. Versiyon Kontrol Sistemi ile Uyumlu Olmalı:
Küçük harf ve tire kullanımı: Git branch isimlerinde küçük harf ve tire (-) kullanmak yaygındır. Bu, branch isimlerinin okunabilirliğini artırır. Örneğin, feature/add-user-login.
Benzersiz olmalı: Her branch ismi projede benzersiz olmalıdır.

7. Takım ve Proje Yapısına Uygun Olmalı:
Proje veya takım spesifik prefixler: Eğer projede birden fazla takım çalışıyorsa, takım isimlerini branch isimlerine dahil etmek faydalı olabilir. Örneğin, frontend/feature/add-login-page, backend/feature/implement-authentication.

9. Kısayollar ve Açıklamalar:
Jira veya Trello gibi araçlarla entegrasyon: Eğer bir proje yönetim aracı kullanılıyorsa, branch isimlerine ilgili ticket numarasını eklemek faydalı olabilir. Örneğin, feature/JIRA-1234-login-implementation, bugfix/TRELLO-567-fix-registration.

Örnekler:

Yeni bir özellik için: feature/add-login
Bir hatayı düzeltmek için: bugfix/fix-login-error
Güvenlik yamaları için: hotfix/security-issue
Yeni bir sürüm hazırlığı için: release/v1.2.0
Rutin işler için: chore/update-dependencies

Bu isimlendirme kurallarına uyarak branch isimleri seçmek, projenizin yönetimini kolaylaştırır ve takım üyeleri arasında anlaşılabilirliği artırır.

