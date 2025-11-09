CREATE PROCEDURE usp_customer_find(
    OUT page_number INT = NULL,
    OUT offset_elements INT = NULL,
    OUT total_pages INT = NULL,
    OUT total_elements INT = NULL,
    customer_id VARCHAR(30) = NULL,
    customer_citizen_id_number VARCHAR(30) = NULL,
    customer_name VARCHAR(200) = NULL,
    customer_email VARCHAR(100) = NULL,
    customer_phone VARCHAR(15) = NULL,
    customer_status VARCHAR(30) = NULL
) AS
$$
BEGIN
    CREATE TEMPORARY TABLE temp_tb AS
    SELECT id,
           customer_id,
           first_name,
           last_name,
           citizen_id_number,
           address1,
           address2,
           phone,
           email,
           status,
           created_at,
           updated_at,
           COUNT(id) OVER () row_count
    FROM customer
    WHERE (customer_id IS NULL OR CAST(id AS VARCHAR(30)) LIKE '%' + customer_id + '%')
      AND (customer_citizen_id_number IS NULL OR citizen_id_number LIKE '%' + customer_citizen_id_number + '%')
      AND (customer_name IS NULL OR first_name + last_name LIKE '%' + customer_name + '%')
      AND (customer_email IS NULL OR email LIKE '%' + customer_email + '%')
      AND (customer_phone IS NULL OR phone LIKE '%' + customer_phone + '%')
      AND (customer_status IS NULL OR status = customer_status);

    SET total_elements = @rowcount
    SET total_pages = CEILING(total_elements/offset_elements)
    IF page_number > total_pages SET page_number = total_pages

    SELECT *
    FROM # TEMP
    ORDER BY customer_id
END
$$;


CREATE PROCEDURE usp_amenity_find
    page_size INT, page_number INT,
    amenity_id VARCHAR (30) = NULL,
    amenity_title VARCHAR (100) = NULL,
    amenity_status VARCHAR (100) = NULL,
    current_page_count INT OUTPUT,
    current_page_number INT OUTPUT,
    current_row_count INT OUTPUT
AS
SELECT id amenity_id, title, detail, price, "status", created_at, updated_at
INTO #find_amenity
FROM amenity
WHERE (amenity_id IS NULL
   OR CAST (id AS VARCHAR (30)) LIKE '%' + amenity_id + '%')
  AND (amenity_title IS NULL
   OR title LIKE '%' + amenity_title + '%')
  AND (amenity_status IS NULL
   OR status = amenity_status)

SET current_row_count = ROWCOUNT

SELECT *
FROM #find_amenity
ORDER BY amenity_id
OFFSET (page_number - 1) * page_size ROWS
FETCH NEXT page_size ROWS ONLY;
go

-- DISCOUNT COUPON SEARCH PROCEDURE
CREATE
    PROCEDURE usp_discountcoupon_find
    page_size INT,
    page_number INT,
    discount_coupon_id VARCHAR (30) = NULL,
    discount_coupon_title VARCHAR (100) = NULL,
    discount_coupon_code VARCHAR (30) = NULL,
    discount_coupon_status VARCHAR (100) = NULL
AS
SELECT id                discount_coupon_id,
       title,
       coupon_code,
       min_balance,
       usage_limit,
       rate_percent,
       expired_at,
       created_at,
       updated_at,
       detail,
       COUNT(id) OVER () row_count
FROM discount_coupon
WHERE (discount_coupon_id IS NULL OR CAST(id AS VARCHAR(30)) LIKE '%' + discount_coupon_id + '%')
  AND (discount_coupon_title IS NULL OR title LIKE '%' + discount_coupon_title + '%')
  AND (discount_coupon_code IS NULL OR coupon_code LIKE '%' + discount_coupon_code + '%')
  AND (discount_coupon_status IS NULL OR status = discount_coupon_status)
ORDER BY id
OFFSET (page_number - 1) * page_size ROWS FETCH NEXT page_size ROWS ONLY;
go


CREATE PROCEDURE usp_user_find(
    page_size INT,
    page_number INT,
    user_name VARCHAR(200) = NULL,
    user_email VARCHAR(100) = NULL,
    user_phone VARCHAR(15) = NULL
)
    LANGUAGE plpgsql
AS
$$
BEGIN
    ;
    SELECT id                user_id,
           first_name,
           last_name,
           phone,
           email,
           status,
           account_password,
           created_at,
           updated_at,
           COUNT(id) OVER () row_count
    FROM user
    WHERE (user_id IS NULL OR CAST(id AS VARCHAR(30)) LIKE '%' + user_id + '%')
      AND (user_name IS NULL OR first_name + last_name LIKE '%' + user_name + '%')
      AND (user_email IS NULL OR email LIKE '%' + user_email + '%')
      AND (user_phone IS NULL OR phone LIKE '%' + user_phone + '%')
      AND (user_status IS NULL OR account_status = user_status)
      AND (user_role IS NULL OR role = user_role)
    ORDER BY id
    OFFSET (page_number - 1) * page_size ROWS FETCH NEXT page_size ROWS ONLY;
END
$$;

-- ROOM TYPE SEARCH PROCEDURE
CREATE
    PROCEDURE usp_roomtype_find
    page_size INT,
    page_number INT,
    room_type_id VARCHAR (30) = NULL,
    room_type_title VARCHAR (100) = NULL
AS
SELECT id room_type_id, title, detail, price_per_night, created_at, updated_at, COUNT(id) OVER () row_count
FROM room_type
WHERE (room_type_id IS NULL OR CAST(id AS VARCHAR(30)) LIKE '%' + room_type_id + '%')
  AND (room_type_title IS NULL OR title LIKE '%' + room_type_title + '%')
ORDER BY id
OFFSET (page_number - 1) * page_size ROWS FETCH NEXT page_size ROWS ONLY;
go


-- HOTel SErVICE SEARCH PROCEDURE
CREATE
    PROCEDURE usp_hotelservice_find
    page_size INT = 1000,
    page_number INT = 1,
    hotel_service_id VARCHAR (30) = NULL,
    hotel_service_title VARCHAR (100) = NULL
AS
SELECT id hotel_service_id, title, detail, COUNT(id) OVER () row_count
FROM hotel_service
WHERE (hotel_service_id IS NULL OR CAST(id AS VARCHAR(30)) LIKE '%' + hotel_service_id + '%')
  AND (hotel_service_title IS NULL OR title LIKE '%' + hotel_service_title + '%')
ORDER BY id
OFFSET (page_number - 1) * page_size ROWS FETCH NEXT page_size ROWS ONLY;
go

--- ROOM SEARCH
CREATE
    PROCEDURE usp_room_find
    page_size INT = 1000,
    page_number INT = 1,
    room_id VARCHAR (30) = NULL,
    room_code VARCHAR (30) = NULL,
    room_type_id VARCHAR (30) = NULL,
    room_status VARCHAR (30) = NULL
AS
SELECT a.id                room_id,
       a.room_code,
       a.floor_number,
       a."status",
       a.created_at,
       a.updated_at,
       COUNT(a.id) OVER () row_count,
       b.id                room_type_id,
       b.title,
       b.detail,
       b.price_per_night,
       b.created_at,
       b.updated_at
FROM room a
         INNER JOIN room_type b ON a.room_type_id = b.id
WHERE (room_id IS NULL OR CAST(a.id AS VARCHAR(30)) LIKE '%' + room_id + '%')
  AND (room_type_id IS NULL OR CAST(a.room_type_id AS VARCHAR(30)) LIKE '%' + room_id + '%')
  AND (room_code IS NULL OR a.room_code LIKE '%' + room_code + '%')
  AND (room_status IS NULL OR a.status = room_status)
ORDER BY a.id
OFFSET (page_number - 1) * page_size ROWS FETCH NEXT page_size ROWS ONLY;
go

-- ROOM FIND ONE
CREATE
    PROCEDURE usp_room_findbyid
    room_id INT
AS
SELECT a.id room_id,
       a.room_code,
       a.floor_number,
       a."status",
       a.created_at,
       a.updated_at,
       b.id room_type_id,
       b.title,
       b.detail,
       b.price_per_night,
       b.created_at,
       b.updated_at,
       c.id room_amenity_id,
       c.created_at,
       d.id amenity_id,
       d.title,
       d.detail,
       d.price,
       d."status",
       d.created_at,
       d.updated_at
FROM room a
         INNER JOIN room_type b ON a.room_type_id = b.id
         INNER JOIN room_amenity c ON c.room_id = a.id
         INNER JOIN amenity d ON d.id = c.amenity_id
WHERE a.id = room_id go
