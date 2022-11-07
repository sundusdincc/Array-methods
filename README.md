# Array-methods
Array Sınıfı ve Methodlari
Diziler System.Array sınıfından türerler. Array sınıfı da dizilerle yapılan işlemleri kolaylaştırmak için bir takım static hazır metotlar sunar. Bu metotlardan en sık kullanılan birkaçına yakından bakalım.

Array.Sort
Diziler üzerinden sıralama işlemi yapar. Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar. Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.

Örnek:

Array.Sort(sayiDizisi);
Array.Clear
Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.

Örnek: Aşağıdaki örnek sayi dizisinin 2.indexinden başlayarak 2 tane elemanı temizler.

Array.Clear(sayiDizisi,2,2);
Array.Reverse
Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

Örnek: Array.Reverse(sayiDizisi);

sayiDizisi elemanlarını {1,3,4,9,8,7} olarak düşünürsek; Reverse metodu uygulandığında dizi şöyle olur : {7,8,9,4,3,1}
