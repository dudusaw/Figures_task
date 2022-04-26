/* https://www.db-fiddle.com/f/d1RFFCxSmd2Qc87nys7Zc1/1 */

create table IF NOT EXISTS category (
  id int,
  name varchar(20),
  PRIMARY KEY (id)
);
  
create table IF NOT EXISTS product (
  id int,
  name varchar(20),
  PRIMARY KEY (id)
);

create table IF NOT EXISTS category_to_product (
  id int,
  category_id int,
  product_id int,
  PRIMARY KEY (id),
  FOREIGN KEY (category_id) REFERENCES category(id),
  FOREIGN KEY (product_id) REFERENCES product(id)
);

insert into category (id, name)
values (1, "c1");
insert into category (id, name)
values (2, "c2");
insert into category (id, name)
values (3, "c3");

insert into product (id, name)
values (1, "p1");
insert into product (id, name)
values (2, "p2");
insert into product (id, name)
values (3, "p3");

insert into category_to_product (id, category_id, product_id)
values (1, 1, 1);
insert into category_to_product (id, category_id, product_id)
values (2, 2, 1);
insert into category_to_product (id, category_id, product_id)
values (3, 3, 2);
insert into category_to_product (id, category_id, product_id)
values (4, 3, 1);
insert into category_to_product (id, category_id, product_id)
values (5, 1, 2);


select product.name as product_name, category.name as category_name
from product
left join category_to_product on product.id = category_to_product.product_id
left join category on category_to_product.category_id = category.id;
