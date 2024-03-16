-- 26. Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını (`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.

select p.product_id, p.product_name, s.company_name, s.phone, p.units_in_stock
from products p
join suppliers s on p.supplier_id = s.supplier_id
where p.units_in_stock < 1;

-- 27. 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı

select o.order_id, o.ship_address, e.first_name, e.last_name, o.order_date
from orders o
join employees e on o.employee_id = e.employee_id
where o.order_date between '1998.03.01' and '1998.03.31';

-- 28. 1997 yılı şubat ayında kaç siparişim var?

select count(*) as "total_orders"
from orders o
where o.order_date between '1997.02.01' and '1997.02.28';

-- 29. London şehrinden 1998 yılında kaç siparişim var?

select count(*) as "total_orders"
from orders o
where o.ship_city = 'London' and (o.order_date between '1998.01.01' and '1998.12.31');

-- 30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası

select distinct c.contact_name, c.phone
from customers c
join orders o on c.customer_id = o.customer_id
where o.order_date between '1997.01.01' and '1997.12.31';

-- 31. Taşıma ücreti 40 üzeri olan siparişlerim

select o.order_id, o.freight
from orders o
where o.freight > 40;

-- 32. Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı

select o.order_id, c.contact_name, o.ship_city, o.freight
from orders o
join customers c on o.customer_id = c.customer_id
where o.freight >= 40;

-- 33. 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı -soyadı ( ad soyad birleşik olacak ve büyük harf),

select o.order_date, o.ship_city, concat(e.first_name, ' ', e.last_name) as "employee_full_name"
from orders o 
join employees e on o.employee_id = e.employee_id
where o.order_date between '1997.01.01' and '1997.12.31';

-- 34. 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları ( telefon formatı 2223322 gibi olmalı )

select distinct c.contact_name, REGEXP_REPLACE(c.phone, '\D', '', 'g') AS formatted_phone
from customers c
join orders o on c.customer_id = o.customer_id
where o.order_date between '1997.01.01' and '1997.12.31';

-- 35. Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad

select o.order_date, c.contact_name as "customer_contact_name", concat(upper(e.first_name), ' ', upper(e.last_name)) as "employee_full_name"
from orders o
join customers c on o.customer_id = c.customer_id
join employees e on o.employee_id = e.employee_id;

-- 36. Geciken siparişlerim?

select *
from orders o
where o.required_date < o.shipped_date;

-- 37. Geciken siparişlerimin tarihi, müşterisinin adı

select o.order_date, c.contact_name
from orders o
join customers c on o.customer_id = c.customer_id
where o.required_date < o.shipped_date;

-- 38. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi

select o.order_id, p.product_name, c.category_name, od.quantity
from orders o 
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
join categories c on p.category_id = c.category_id
where o.order_id = 10248;

-- 39. 10248 nolu siparişin ürünlerinin adı , tedarikçi adı

select o.order_id, p.product_name, s.company_name
from orders o 
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
join suppliers s on p.supplier_id = s.supplier_id
where o.order_id = 10248;

-- 40. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti

select e.employee_id, p.product_name, od.quantity, o.order_date
from employees e
join orders o on e.employee_id = o.employee_id
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
where e.employee_id = 3 and (o.order_date between '1997.01.01' and '1997.12.31');

-- 41. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad

select e.employee_id, e.first_name, e.last_name, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price"
from employees e
join orders o on e.employee_id = o.employee_id
join order_details od on o.order_id = od.order_id
group by e.employee_id, o.order_date
having o.order_date between '1997.01.01' and '1997.12.31'
order by total_order_price desc
limit 1;

-- 42. 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad ****

select a.employee_id, a.first_name, a.last_name, sum(total_order_price) as "total_order_price_of_employee"
from (select e.employee_id, e.first_name, e.last_name, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price"
	  from employees e
	  join orders o on e.employee_id = o.employee_id
	  join order_details od on o.order_id = od.order_id
	  group by e.employee_id, o.order_date
	  having o.order_date between '1997.01.01' and '1997.12.31'
	  order by total_order_price desc) a
join employees e on a.employee_id = e.employee_id
group by a.employee_id, e.first_name, e.last_name
order by total_order_price_of_employee desc
limit 1;

-- 43. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?

select p.product_name, p.unit_price, c.category_name
from products p
join categories c on p.category_id = c.category_id
order by p.unit_price desc
limit 1;

-- 44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre

select e.employee_id, e.first_name, e.last_name, o.order_id, o.order_date
from employees e
join orders o on e.employee_id = o.employee_id
order by o.order_date

-- 45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?

select (sum(total_order_price) / 5) as "average_price_of_last_five_orders"
from (select o.order_id, o.order_date, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price" 
	  from order_details od
	  join orders o on od.order_id = o.order_id
	  group by o.order_id, o.order_date
	  order by o.order_date desc
	  limit 5)

-- 46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?

select p.product_name, c.category_name, sum(od.quantity) as "total_order"
from orders o
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
join categories c on p.category_id = c.category_id
where extract(month from o.order_date) = 1
group by p.product_name, c.category_name;

-- 47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?

select o.order_id, sum(od.quantity * od.unit_price * (1 - od.discount))
from orders o
join order_details od on o.order_id = od.order_id
group by o.order_id
having sum(od.quantity * od.unit_price * (1 - od.discount)) > (select avg(total_order_price)
							from (select o.order_id, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price"
								  from orders o
								  join order_details od on o.order_id = od.order_id
								  group by o.order_id
								  order by o.order_id asc))

-- 48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı

select p.product_name, c.category_name, s.company_name, sum(od.quantity) as total_sold
from products p
join categories c on p.category_id = c.category_id
join suppliers s on p.supplier_id = s.supplier_id
join order_details od on p.product_id = od.product_id
group by p.product_name, c.category_name, s.company_name
order by total_sold desc
limit 1;

-- 49. Kaç ülkeden müşterim var

select count(distinct c.country) as total_country_count
from customers c;

-- 50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?

select e.employee_id, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_endorsement"
from employees e
join orders o on e.employee_id = e.employee_id
join order_details od on o.order_id = od.order_id
group by e.employee_id, o.order_date
having e.employee_id = 3 and o.order_date > '2024-01-01';

-- 65. 10 numaralı ID ye sahip ürünümden son 3 ayda ne kadarlık ciro sağladım?

select p.product_id, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_endorsement"
from products p
join order_details od on p.product_id = od.product_id
join orders o on od.order_id = o.order_id
group by p.product_id, o.order_date
having p.product_id = 10 and o.order_date > current_date - interval '3 months';

-- 66. Hangi çalışan şimdiye kadar toplam kaç sipariş almış..?

select concat(e.first_name, ' ', e.last_name) as "employee_full_name", count(o.order_id) as "order_count"
from employees e
join orders o on e.employee_id = o.employee_id
group by employee_full_name

-- 67. 91 müşterim var. Sadece 89’u sipariş vermiş. Sipariş vermeyen 2 kişiyi bulun

select c.contact_name, o.order_id
from customers c
left join orders o on c.customer_id = o.customer_id
where o.order_id is null
order by c.contact_name asc

-- 68. Brazil’de bulunan müşterilerin Şirket Adı, TemsilciAdi, Adres, Şehir, Ülke bilgileri

select c.company_name, c.contact_name, c.address, c.city, c.country
from customers c
where c.country = 'Brazil';

-- 69. Brezilya’da olmayan müşteriler

select c.contact_name, c.country
from customers c
where c.country != 'Brazil';

-- 70. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler

select c.contact_name, c.country
from customers c
where c.country = 'Spain' or  c.country = 'France' or c.country = 'Germany';

-- 71. Faks numarasını bilmediğim müşteriler

select c.contact_name, c.fax
from customers c
where c.fax is null;

-- 72. Londra’da ya da Paris’de bulunan müşterilerim

select c.contact_name, c.city
from customers c
where c.city = 'London' or c.city = 'Paris';

-- 73. Hem Mexico D.F’da ikamet eden HEM DE ContactTitle bilgisi ‘owner’ olan müşteriler

select c.contact_name, c.city, c.contact_title
from customers c
where c.city = 'México D.F.' and c.contact_title = 'Owner';

-- 74. C ile başlayan ürünlerimin isimleri ve fiyatları

select p.product_name, p.unit_price
from products p
where lower(p.product_name) like 'c%';

-- 75. Adı (FirstName) ‘A’ harfiyle başlayan çalışanların (Employees); Ad, Soyad ve Doğum Tarihleri

select e.first_name, e.last_name, e.birth_date
from employees e
where lower(e.first_name) like 'a%';

-- 76. İsminde ‘RESTAURANT’ geçen müşterilerimin şirket adları

select c.company_name
from customers c
where lower(c.company_name) like '%restaurant%';

-- 77. 50$ ile 100$ arasında bulunan tüm ürünlerin adları ve fiyatları

select p.product_name, p.unit_price
from products p
where p.unit_price between 50 and 100;

-- 78. 1 temmuz 1996 ile 31 Aralık 1996 tarihleri arasındaki siparişlerin (Orders), SiparişID (OrderID) ve SiparişTarihi (OrderDate) bilgileri

select o.order_id, o.order_date
from orders o
where o.order_date between '1996-07-01' and '1996-12-31';

-- 81. Müşterilerimi ülkeye göre sıralıyorum:

select c.contact_name, c.country
from customers c
order by c.country asc;

-- 82. Ürünlerimi en pahalıdan en ucuza doğru sıralama, sonuç olarak ürün adı ve fiyatını istiyoruz

select p.product_name, p.unit_price
from products p
order by p.unit_price desc;

-- 83. Ürünlerimi en pahalıdan en ucuza doğru sıralasın, ama stoklarını küçükten-büyüğe doğru göstersin sonuç olarak ürün adı ve fiyatını istiyoruz

select p.product_name, p.unit_price
from products p
order by p.unit_price desc, p.units_in_stock asc;

-- 84. 1 Numaralı kategoride kaç ürün vardır..?

select c.category_id, count(*) as "total_product_count"
from categories c
join products p on c.category_id = p.category_id
group by c.category_id
having c.category_id = 1;

-- 85. Kaç farklı ülkeye ihracat yapıyorum..?

select count(distinct c.country) as total_country_count
from customers c;

-- 86. a.Bu ülkeler hangileri..?

select distinct c.country
from customers c
order by c.country asc;

-- 87. En Pahalı 5 ürün

select p.product_name, p.unit_price
from products p
order by p.unit_price desc
limit 5;

-- 88. ALFKI CustomerID’sine sahip müşterimin sipariş sayısı..?

select c.customer_id, count(*) as "total_order_count"
from customers c
join orders o on c.customer_id = o.customer_id
group by c.customer_id
having c.customer_id = 'ALFKI';

-- 89. Ürünlerimin toplam maliyeti

select * from products; -- urunlerin fiyatlari var ama maliyetlerinin yazdigi kismi bulamadim

-- 90. Şirketim, şimdiye kadar ne kadar ciro yapmış..?

select sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_endorsement"
from order_details od;

-- 91. Ortalama Ürün Fiyatım

select avg(p.unit_price) as "average_product_price"
from products p;

-- 92. En Pahalı Ürünün Adı

select p.product_name, p.unit_price
from products p
order by p.unit_price desc
limit 1;

-- 93. En az kazandıran sipariş

select o.order_id, sum(od.quantity * od.unit_price * (1 - od.discount)) as total_gained
from orders o
join order_details od on o.order_id = od.order_id
group by o.order_id
order by sum(od.quantity * od.unit_price) asc
limit 1;

-- 94. Müşterilerimin içinde en uzun isimli müşteri

select c.contact_name, length(c.contact_name)
from customers c
group by c.contact_name
order by length(c.contact_name) desc
limit 1;

-- 95. Çalışanlarımın Ad, Soyad ve Yaşları

select e.first_name, e.last_name, date_part('year', age(current_date, e.birth_date)) as "age"
from employees e;

-- 96. Hangi üründen toplam kaç adet alınmış..?

select p.product_name, sum(od.quantity) as total_buy_count
from products p
join order_details od on p.product_id = od.product_id
group by p.product_name
order by p.product_name asc;

-- 97. Hangi siparişte toplam ne kadar kazanmışım..?

select o.order_id, sum(od.quantity * od.unit_price) as total_gained
from orders o
join order_details od on o.order_id = od.order_id
group by o.order_id
order by o.order_id asc;

-- 98. Hangi kategoride toplam kaç adet ürün bulunuyor..?

select c.category_name, count(*) as total_product_count
from categories c
join products p on c.category_id = p.category_id
group by c.category_id
order by category_name asc;

-- 99. 1000 Adetten fazla satılan ürünler?

select p.product_name, sum(od.quantity) as total_sold_count
from products p
join order_details od on p.product_id = od.product_id
group by p.product_name
having sum(od.quantity) > 1000
order by sum(od.quantity) desc;

-- 100. Hangi Müşterilerim hiç sipariş vermemiş..?

select c.company_name, o.order_id
from customers c
left join orders o on c.customer_id = o.customer_id
where o.order_id is null;