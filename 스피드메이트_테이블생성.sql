-- ���̺� ������ ���踦 ����Ͽ� �� ���� �����ص� ������ �߻����� �ʰ� ���ĵǾ����ϴ�.

-- car_t Table Create SQL
CREATE TABLE car_t
(
    car_id     INT             NOT NULL, 
    model      VARCHAR2(20)    NOT NULL, 
    car_num    VARCHAR2(20)    NOT NULL, 
    cc         VARCHAR2(20)    NOT NULL, 
    year       VARCHAR2(20)    NOT NULL, 
     PRIMARY KEY (car_id)
)
/

CREATE SEQUENCE car_t_SEQ
START WITH 1
INCREMENT BY 1;
/

--DROP TRIGGER car_t_AI_TRG;
/

--DROP SEQUENCE car_t_SEQ;
/

COMMENT ON TABLE car_t IS '��������'
/

COMMENT ON COLUMN car_t.car_id IS '����ID'
/

COMMENT ON COLUMN car_t.model IS '������'
/

COMMENT ON COLUMN car_t.car_num IS '������ȣ'
/

COMMENT ON COLUMN car_t.cc IS '��ⷮ'
/

COMMENT ON COLUMN car_t.year IS '����'
/


-- staff_t Table Create SQL
CREATE TABLE staff_t
(
    staff_id     INT             NOT NULL, 
    name         VARCHAR2(20)    NOT NULL, 
    tel          VARCHAR2(20)    NOT NULL, 
    birth        VARCHAR2(20)    NOT NULL, 
    rank         VARCHAR2(20)    NOT NULL, 
    work_type    VARCHAR2(20)    NOT NULL, 
    salary       VARCHAR2(20)    NOT NULL, 
     PRIMARY KEY (staff_id)
)
/

CREATE SEQUENCE staff_t_SEQ
START WITH 1
INCREMENT BY 1;
/

--DROP TRIGGER staff_t_AI_TRG;
/

--DROP SEQUENCE staff_t_SEQ;
/

COMMENT ON TABLE staff_t IS '��������'
/

COMMENT ON COLUMN staff_t.staff_id IS '����ID'
/

COMMENT ON COLUMN staff_t.name IS '�̸�'
/

COMMENT ON COLUMN staff_t.tel IS '��ȭ'
/

COMMENT ON COLUMN staff_t.birth IS '�������'
/

COMMENT ON COLUMN staff_t.rank IS '����'
/

COMMENT ON COLUMN staff_t.work_type IS '������'
/

COMMENT ON COLUMN staff_t.salary IS '�޿�'
/

insert into staff_t values (1, '����ġ', '010-1234-1111', '1980��5��2��', '�븮', '������', '250����');
insert into staff_t values (2, '���ġ', '010-1234-2222', '1980��6��2��', '����', '������', '300����');
insert into staff_t values (3, '�ڿ�ġ', '010-1234-3333', '1980��7��2��', '����', '������', '400����');
insert into staff_t values (4, '�̿�ġ', '010-1234-4444', '1980��8��2��', '����', '������', '500����');

-- customer_t Table Create SQL
CREATE TABLE customer_t
(
    cust_id    INT             NOT NULL, 
    name       VARCHAR2(20)    NOT NULL, 
    birth      VARCHAR2(20)    NOT NULL, 
    tel        VARCHAR2(20)    NOT NULL, 
    car_id     INT             NOT NULL, 
     PRIMARY KEY (cust_id)
)
/

CREATE SEQUENCE customer_t_SEQ
START WITH 1
INCREMENT BY 1;
/

--DROP TRIGGER customer_t_AI_TRG;
/

--DROP SEQUENCE customer_t_SEQ;
/

COMMENT ON TABLE customer_t IS '������'
/

COMMENT ON COLUMN customer_t.cust_id IS '��ID'
/

COMMENT ON COLUMN customer_t.name IS '�̸�'
/

COMMENT ON COLUMN customer_t.birth IS '�������'
/

COMMENT ON COLUMN customer_t.tel IS '��ȭ'
/

COMMENT ON COLUMN customer_t.car_id IS '����ID'
/

ALTER TABLE customer_t
    ADD CONSTRAINT FK_customer_t_car_id_car_t_car FOREIGN KEY (car_id)
        REFERENCES car_t (car_id)
/


-- receipt_t Table Create SQL
CREATE TABLE receipt_t
(
    receipt_id     INT             NOT NULL, 
    indate         VARCHAR2(20)    NOT NULL, 
    total_price    VARCHAR2(20)    NOT NULL, 
    repair_chk     VARCHAR2(20)    NOT NULL, 
    cust_id        INT             NOT NULL, 
    staff_id       INT             NOT NULL, 
     PRIMARY KEY (receipt_id)
)
/

CREATE SEQUENCE receipt_t_SEQ
START WITH 1
INCREMENT BY 1;
/

--DROP TRIGGER receipt_t_AI_TRG;
/

--DROP SEQUENCE receipt_t_SEQ;
/

COMMENT ON TABLE receipt_t IS '��������'
/

COMMENT ON COLUMN receipt_t.receipt_id IS '����ID'
/

COMMENT ON COLUMN receipt_t.indate IS '������¥'
/

COMMENT ON COLUMN receipt_t.total_price IS '�Ѱ����ݾ�'
/

COMMENT ON COLUMN receipt_t.repair_chk IS '��������'
/

COMMENT ON COLUMN receipt_t.cust_id IS '��ID'
/

COMMENT ON COLUMN receipt_t.staff_id IS '����ID'
/

ALTER TABLE receipt_t
    ADD CONSTRAINT FK_receipt_t_cust_id_customer_ FOREIGN KEY (cust_id)
        REFERENCES customer_t (cust_id)
/

ALTER TABLE receipt_t
    ADD CONSTRAINT FK_receipt_t_staff_id_staff_t_ FOREIGN KEY (staff_id)
        REFERENCES staff_t (staff_id)
/


-- repair_item_t Table Create SQL
CREATE TABLE repair_item_t
(
    repair_item_id    INT             NOT NULL, 
    repair            VARCHAR2(20)    NOT NULL, 
    price             VARCHAR2(20)    NOT NULL, 
    car_id            INT             NOT NULL, 
     PRIMARY KEY (repair_item_id)
)
/

CREATE SEQUENCE repair_item_t_SEQ
START WITH 1
INCREMENT BY 1;
/

--DROP TRIGGER repair_item_t_AI_TRG;
/

--DROP SEQUENCE repair_item_t_SEQ;
/

COMMENT ON TABLE repair_item_t IS '�����׸�'
/

COMMENT ON COLUMN repair_item_t.repair_item_id IS '�����׸�ID'
/

COMMENT ON COLUMN repair_item_t.repair IS '��������'
/

COMMENT ON COLUMN repair_item_t.price IS '�����ܰ�'
/

COMMENT ON COLUMN repair_item_t.car_id IS '����ID'
/

ALTER TABLE repair_item_t
    ADD CONSTRAINT FK_repair_item_t_car_id_car_t_ FOREIGN KEY (car_id)
        REFERENCES car_t (car_id)
/

create or REPLACE view 
    receipt_view
as select
    indate as ������¥,
    total_price as �Ѱ����ݾ�,
    (select staff_t.name from staff_t 
        where staff_t.staff_id = receipt_t.staff_id) as �����,
    (select customer_t.name from customer_t
        where customer_t.cust_id = receipt_t.cust_id) as ����,
    (select customer_t.tel from customer_t
        where customer_t.cust_id = receipt_t.cust_id) as ����ȭ,
    (select car_t.car_num from car_t 
        where car_t.car_id = receipt_t.cust_id) as ������ȣ,
    repair_chk as ��������
from receipt_t order by receipt_id desc;

