Select * from products;

select product_name,unit_price from products;

-- where koşulu ==> istediğimiz koşulu listeler

Select * from products where category_id=2;

-- birden fazla koşul sağlama ve filtreleme için. Örneğin stok sayısı 60dan büyük ve categoryid'si 3 olanları listeleyelim.

Select product_name,units_in_stock,category_id from products where units_in_stock>60 and category_id=3;

-- iki koşuldan birinin sağlanması durumu
Select product_name,units_in_stock,category_id from products where units_in_stock>60 or category_id=3;

-- and

Select product_name,units_in_stock,category_id from products where units_in_stock>=60 and units_in_stock<=120;

-- belirtilen değerler arasında listeleme
Select product_name,units_in_stock,category_id from products where units_in_stock Between 40 and 100;

Select product_name,units_in_stock,category_id from products where category_id Between 2 and 5;

--COUNTER => adet sayisi
--alisa => takma isim

Select COUNT(*) AS "urun_adedi" from products where unit_price > 50;

Select city from employees;

select count(city) from employees;
select city from employees;

-- disctinct

select distinct city from employees;

select count(distinct city) as "sehirler" from employees;

select * from products;

select * from products where product_name = 'Chai' or product_name = 'Chang' or product_name = 'Aniseed Syrup';

-- in fonksiyonu icerisinde parametre olarak verilen n kadar veri

select * from products where product_name IN('Chai', 'Chang', 'Aniseed Syrup');

select * from products where category_id IN(2,3,5);

select * from products where product_name = 'Chef Anton''s Cajun Seasoning';

--LIKE keywordu
-- pattern => kaliba benzer ifadeleri getirir
-- % => ilgili metnin sol ayada sagina eklendiginde

select * from products where product_name like 'Gei%';
select * from products where product_name like '%ost';
select * from products where product_name like 'Gei__st';

-- sum => toplama
select sum(unit_price) as "total unit price" from products;

-- avg => ortalama
select avg(unit_price) as "average unit price" from products;

select max(unit_price) as "max unit price" from products;
select min(unit_price) as "min unit price" from products;

--order by => siralama
--default olarak kucukten buyuge
--descending desc buyukten kucuge
--ascending asc kucukgen buyuge

select product_name, unit_price from products order by unit_price desc;
select product_name, unit_price from products order by unit_price asc;
select product_name, unit_price from products where unit_price > 50 order by unit_price asc;

--sub query ic ice sorgular
-- ortalamanin altinda bi fiyata sahip olan

select product_name, unit_price from products where unit_price < (select avg(unit_price) from products);

select product_name, unit_price from products where unit_price = (select max(unit_price) from products);

select product_name, unit_price from products where unit_price = (select min(unit_price) from products);