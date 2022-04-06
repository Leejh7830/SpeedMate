-- 테이블 순서는 관계를 고려하여 한 번에 실행해도 에러가 발생하지 않게 정렬되었습니다.

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

COMMENT ON TABLE car_t IS '차량정보'
/

COMMENT ON COLUMN car_t.car_id IS '차량ID'
/

COMMENT ON COLUMN car_t.model IS '차량모델'
/

COMMENT ON COLUMN car_t.car_num IS '차량번호'
/

COMMENT ON COLUMN car_t.cc IS '배기량'
/

COMMENT ON COLUMN car_t.year IS '연식'
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

COMMENT ON TABLE staff_t IS '직원정보'
/

COMMENT ON COLUMN staff_t.staff_id IS '직원ID'
/

COMMENT ON COLUMN staff_t.name IS '이름'
/

COMMENT ON COLUMN staff_t.tel IS '전화'
/

COMMENT ON COLUMN staff_t.birth IS '생년월일'
/

COMMENT ON COLUMN staff_t.rank IS '직위'
/

COMMENT ON COLUMN staff_t.work_type IS '고용상태'
/

COMMENT ON COLUMN staff_t.salary IS '급여'
/

insert into staff_t values (1, '전우치', '010-1234-1111', '1980년5월2일', '대리', '정규직', '250만원');
insert into staff_t values (2, '김우치', '010-1234-2222', '1980년6월2일', '과장', '정규직', '300만원');
insert into staff_t values (3, '박우치', '010-1234-3333', '1980년7월2일', '차장', '정규직', '400만원');
insert into staff_t values (4, '이우치', '010-1234-4444', '1980년8월2일', '소장', '정규직', '500만원');

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

COMMENT ON TABLE customer_t IS '고객정보'
/

COMMENT ON COLUMN customer_t.cust_id IS '고객ID'
/

COMMENT ON COLUMN customer_t.name IS '이름'
/

COMMENT ON COLUMN customer_t.birth IS '생년월일'
/

COMMENT ON COLUMN customer_t.tel IS '전화'
/

COMMENT ON COLUMN customer_t.car_id IS '차량ID'
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

COMMENT ON TABLE receipt_t IS '접수내역'
/

COMMENT ON COLUMN receipt_t.receipt_id IS '접수ID'
/

COMMENT ON COLUMN receipt_t.indate IS '접수날짜'
/

COMMENT ON COLUMN receipt_t.total_price IS '총결제금액'
/

COMMENT ON COLUMN receipt_t.repair_chk IS '수리상태'
/

COMMENT ON COLUMN receipt_t.cust_id IS '고객ID'
/

COMMENT ON COLUMN receipt_t.staff_id IS '직원ID'
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

COMMENT ON TABLE repair_item_t IS '수리항목'
/

COMMENT ON COLUMN repair_item_t.repair_item_id IS '수리항목ID'
/

COMMENT ON COLUMN repair_item_t.repair IS '수리내역'
/

COMMENT ON COLUMN repair_item_t.price IS '수리단가'
/

COMMENT ON COLUMN repair_item_t.car_id IS '차량ID'
/

ALTER TABLE repair_item_t
    ADD CONSTRAINT FK_repair_item_t_car_id_car_t_ FOREIGN KEY (car_id)
        REFERENCES car_t (car_id)
/

create or REPLACE view 
    receipt_view
as select
    indate as 접수날짜,
    total_price as 총결제금액,
    (select staff_t.name from staff_t 
        where staff_t.staff_id = receipt_t.staff_id) as 담당자,
    (select customer_t.name from customer_t
        where customer_t.cust_id = receipt_t.cust_id) as 고객명,
    (select customer_t.tel from customer_t
        where customer_t.cust_id = receipt_t.cust_id) as 고객전화,
    (select car_t.car_num from car_t 
        where car_t.car_id = receipt_t.cust_id) as 차량번호,
    repair_chk as 수리상태
from receipt_t order by receipt_id desc;

