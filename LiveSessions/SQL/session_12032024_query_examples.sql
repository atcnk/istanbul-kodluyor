--join 
--inner join
select product_name,category_name from products pd
inner join categories ct on pd.category_id=ct.category_id

--hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş
--orders --shippers

select o.order_id,o.order_date,s.company_name,o.shipped_date from orders o
inner join shippers s on o.ship_via = s.shipper_id


--hangi siparişi hangi çalışan almış hangi müşteri vermiş?
--orders , employees,customers
select o.order_id,e.first_name,e.last_name,cs.company_name from orders o
inner join employees e on o.employee_id = e.employee_id
inner join customers cs on o.customer_id=cs.customer_id

--left join
--çalışanların müşterilerden aldığı siparişler

select e.first_name,o.order_id from employees e
left join orders o on e.employee_id=o.employee_id

select * from orders where employee_id=10

select * from employees where employee_id=10


--right join
--hiç sipariş vermemiş müşterileri görmek

select o.order_id,cs.company_name from orders o
right join customers cs on o.customer_id=cs.customer_id 
where order_id is null


--full outer join 
select order_id,company_name,orders.customer_id from orders
full outer join customers on customers.customer_id=orders.customer_id

SELECT SUBSTRING(CAST(unit_price AS VARCHAR), 1, 5) FROM products;
--29.99 34.574.45

--group by
select product_id,sum(quantity) as "toplam miktarı" from order_details
group by product_id
order by product_id

--hangi kategoride toplam kaç ürün var?
select category_id,count(product_id) as "toplam ürün sayısı" from products
group by category_id

select category_name,count(*) as "toplam ürün sayısı" from products pr
inner join categories ct on ct.category_id=pr.category_id
group by category_name

--hangi ülkeye ne kadarlık bir satış yapılmıştır?
select cs.country,sum(od.quantity*od.unit_price) as "Toplam Satış" from customers cs
inner join orders o on o.customer_id=cs.customer_id
inner join order_details od on o.order_id=od.order_id
group by cs.country
order by "Toplam Satış" desc

--filtreleme
--having 

--where => quantity>10
--having => ram'de işlem yapılan verilerin şartını koşuyor 

select product_id,SUM(quantity) as "Toplam miktar"  from order_details
group by product_id
having SUM(quantity)>450
order by product_id

--stok sayısı 15'den fazla olan --toplam ürün sayısı 5'den fazla olan
select category_id,Count(*) "toplam ürün sayısı" from products
where units_in_stock>15
group by category_id
having count(*) > 5

--toplamı 250 adetten fazla satılan ürünler
select product_name,SUM(quantity) as "toplam miktar" from order_details od
inner join products pr on od.product_id=pr.product_id
group by product_name
having SUM(quantity)>250
order by "toplam miktar" asc