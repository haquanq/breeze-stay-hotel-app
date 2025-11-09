CREATE TYPE CUSTOMER_PERSONAL_ID_TYPE_ENUM AS ENUM ('PASSPORT', 'NATIONAL_ID', 'DRIVER_LICENSE', 'OTHER');
CREATE TYPE USER_STATUS_ENUM AS ENUM ('ACTIVE', 'RETIRED', 'SUSPENDED');
CREATE TYPE CUSTOMER_STATUS_ENUM AS ENUM ('NEW', 'COMMON', 'VIP');
CREATE TYPE ROOM_STATUS_ENUM AS ENUM ('VACANT_DIRTY', 'VACANT_CLEAN', 'READY', 'BOOKED', 'OCCUPIED');
CREATE TYPE AMENITY_USAGE_STATUS_ENUM AS ENUM ('PENDING', 'USED', 'UNUSED');
CREATE TYPE RESERVATION_STATUS_ENUM AS ENUM ('PENDING', 'CHECKED_IN', 'CHECKED_OUT', 'CANCELLED');

CREATE TABLE customer
(
    id INT GENERATED ALWAYS AS IDENTITY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    personal_id VARCHAR(30) NOT NULL,
    personal_id_type CUSTOMER_PERSONAL_ID_TYPE_ENUM NOT NULL,
    personal_id_note VARCHAR(255),
    address VARCHAR(255) NOT NULL,
    phone VARCHAR(15) NOT NULL,
    email VARCHAR(255) NOT NULL,
    status CUSTOMER_STATUS_ENUM NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_customer__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_customer__updated_at DEFAULT NOW(),
    CONSTRAINT pk_customer PRIMARY KEY (id),
    CONSTRAINT uq_customer__personal_id UNIQUE (personal_id),
    CONSTRAINT uq_customer__phone UNIQUE (phone),
    CONSTRAINT uq_customer__email UNIQUE (email)
);

CREATE TABLE "user"
(
    id INT GENERATED ALWAYS AS IDENTITY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    date_of_birth DATE NOT NULL,
    phone VARCHAR(15) NOT NULL,
    email VARCHAR(320) NOT NULL,
    role VARCHAR(30) NOT NULL,
    account_username VARCHAR(50) NOT NULL,
    account_password VARCHAR(30) NOT NULL,
    status USER_STATUS_ENUM NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_user__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_user__updated_at DEFAULT NOW(),

    CONSTRAINT pk_user PRIMARY KEY (id),
    CONSTRAINT uq_user__phone UNIQUE (phone),
    CONSTRAINT uq_user__email UNIQUE (email)
);
CREATE TABLE room
(
    id INT GENERATED ALWAYS AS IDENTITY,
    room_type_id INT NOT NULL,
    room_code VARCHAR(30) NOT NULL,
    floor_number INT NOT NULL,
    status ROOM_STATUS_ENUM NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_room__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_room__updated_at DEFAULT NOW(),

    CONSTRAINT pk_room PRIMARY KEY (id),
    CONSTRAINT uq_room__code UNIQUE (room_code)
);
CREATE TABLE room_type
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(200) NOT NULL,
    description VARCHAR(500),
    price_per_night DECIMAL(10, 2) NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_room_type__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_room_type__updated_at DEFAULT NOW(),

    CONSTRAINT pk_room_type PRIMARY KEY (id),
    CONSTRAINT uq_room_type__title UNIQUE (name)
);
CREATE TABLE amenity
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(200) NOT NULL,
    description VARCHAR(500),
    price NUMERIC(10, 2) NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_amenity__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_amenity__updated_at DEFAULT NOW(),

    CONSTRAINT pk_amenity PRIMARY KEY (id),
    CONSTRAINT uq_amenity__title UNIQUE (name)
);
CREATE TABLE room_amenity
(
    id INT GENERATED ALWAYS AS IDENTITY,
    room_id INT NOT NULL,
    amenity_id INT NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_room_amenity__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_room_amenity__updated_at DEFAULT NOW(),

    CONSTRAINT pk_room_amenity PRIMARY KEY (id),
    CONSTRAINT uq_room_amenity__room__amenity UNIQUE (room_id, amenity_id)
);
CREATE TABLE amenity_usage
(
    id INT GENERATED ALWAYS AS IDENTITY,
    reservation_id INT NOT NULL,
    room_id INT NOT NULL,
    amenity_id INT NOT NULL,
    price DECIMAL(10, 2),
    status AMENITY_USAGE_STATUS_ENUM NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_amenity_usage__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_amenity_usage__updated_at DEFAULT NOW(),

    CONSTRAINT pk_amenity_usage PRIMARY KEY (id),
    CONSTRAINT uq_amenity_usage__reservation__room__amenity UNIQUE (reservation_id, room_id, amenity_id)
);
CREATE TABLE reservation
(
    id INT GENERATED ALWAYS AS IDENTITY,
    customer_id INT NOT NULL,
    user_id INT NOT NULL,
    started_at TIMESTAMPTZ NOT NULL,
    ended_at TIMESTAMPTZ NOT NULL,
    checked_in_at TIMESTAMPTZ,
    checked_out_at TIMESTAMPTZ,
    cancelled_at TIMESTAMPTZ,
    total_balance DECIMAL(10, 2),
    status RESERVATION_STATUS_ENUM NOT NULL,
    created_at TIMESTAMPTZ NOT NULL CONSTRAINT df_reservation__created_at DEFAULT NOW(),
    updated_at TIMESTAMPTZ NOT NULL CONSTRAINT df_reservation__updated_at DEFAULT NOW(),

    CONSTRAINT pk_reservation PRIMARY KEY (id)
);
CREATE TABLE reservation_room
(
    id INT GENERATED ALWAYS AS IDENTITY,
    reservation_id INT NOT NULL,
    room_id INT NOT NULL,
    price_per_night DECIMAL(10, 2) NOT NULL,

    CONSTRAINT pk_reservation_room PRIMARY KEY (id),
    CONSTRAINT uq_reservation_room__reservation__room UNIQUE (reservation_id, room_id)
);

ALTER TABLE room
    ADD CONSTRAINT fk_room__room_type FOREIGN KEY (room_type_id) REFERENCES room_type (id);
ALTER TABLE room_amenity
    ADD CONSTRAINT fk_room_amenity__amenity FOREIGN KEY (amenity_id) REFERENCES amenity (id),
    ADD CONSTRAINT fk_room_amenity__room FOREIGN KEY (room_id) REFERENCES room (id);
ALTER TABLE amenity_usage
    ADD CONSTRAINT fk_amenity_usage__reservation FOREIGN KEY (reservation_id) REFERENCES reservation (id) ON DELETE CASCADE,
    ADD CONSTRAINT fk_amenity_usage__room FOREIGN KEY (room_id) REFERENCES room (id),
    ADD CONSTRAINT fk_amenity_usage__amenity FOREIGN KEY (amenity_id) REFERENCES amenity (id);
ALTER TABLE reservation
    ADD CONSTRAINT fk_reservation__customer FOREIGN KEY (customer_id) REFERENCES customer (id),
    ADD CONSTRAINT fk_reservation__user FOREIGN KEY (user_id) REFERENCES "user" (id);
ALTER TABLE reservation_room
    ADD CONSTRAINT fk_reservation_room__reservation FOREIGN KEY (reservation_id) REFERENCES reservation (id) ON DELETE CASCADE,
    ADD CONSTRAINT fk_reservation_room__room FOREIGN KEY (room_id) REFERENCES room (id);