INSERT INTO amenity (name, description, price)
VALUES ('Air Conditioning', 'Individually controlled air conditioning system.', 0.00),
       ('Smart TV', '43-inch smart TV with streaming apps and cable channels.', 0.00),
       ('Mini Refrigerator', 'Compact fridge stocked with complimentary bottled water.', 0.00),
       ('Private Bathroom', 'Ensuite bathroom with shower, toilet, and toiletries.', 0.00),
       ('King-Size Bed', 'Spacious king bed with premium linen set.', 0.00),
       ('Work Desk', 'Ergonomic desk and chair for laptop use.', 0.00),
       ('Room Safe', 'Electronic safe for valuables and documents.', 0.00),
       ('Coffee & Tea Set', 'Electric kettle with instant coffee, tea, and mugs.', 0.00),
       ('Hair Dryer', 'Wall-mounted or drawer-stored hair dryer.', 0.00),
       ('Balcony Access', 'Private balcony with chairs and outdoor table.', 10.00),
       ('Ocean View Upgrade', 'Guaranteed sea view from room window.', 25.00),
       ('Soundproof Walls', 'Enhanced sound insulation for quiet stay.', 0.00),
       ('Complimentary Bottled Water', 'Two bottles of water replenished daily.', 0.00),
       ('Iron & Ironing Board', 'Available in-room for garment pressing.', 5.00),
       ('Smart Lighting', 'Adjustable lighting with remote or voice control.', 8.00);

INSERT INTO room_type (name, description, price_per_night)
VALUES ('Single Room', 'Compact room with one single bed and essential amenities.', 45.00),
       ('Double Room', 'Comfortable room with one double bed, ideal for couples.', 65.00),
       ('Twin Room', 'Room with two single beds, perfect for friends or coworkers.', 70.00),
       ('Family Room', 'Spacious room with one double and two single beds.', 95.00),
       ('Deluxe Room', 'Larger double room with upgraded furnishings and balcony.', 110.00),
       ('Suite', 'Luxury suite with living area, king bed, and premium view.', 160.00),
       ('Penthouse Suite', 'Top-floor suite with panoramic city view and premium decor.', 250.00);

-- Generate rooms (3 per type = 21 total)
INSERT INTO room (room_type_id, room_code, floor_number, status)
VALUES
    -- Single Room
    (1, '101', 1, 'READY'),
    (1, '102', 1, 'READY'),
    (1, '103', 1, 'READY'),
    -- Double Room
    (2, '104', 1, 'READY'),
    (2, '105', 1, 'READY'),
    (2, '106', 1, 'READY'),
    -- Twin Room
    (3, '201', 2, 'READY'),
    (3, '202', 2, 'READY'),
    (3, '203', 2, 'READY'),
    -- Family Room
    (4, '204', 2, 'READY'),
    (4, '205', 2, 'READY'),
    (4, '206', 2, 'READY'),
    -- Deluxe Room
    (5, '301', 3, 'READY'),
    (5, '302', 3, 'READY'),
    (5, '303', 3, 'READY'),
    -- Suite
    (6, '304', 3, 'READY'),
    (6, '305', 3, 'READY'),
    (6, '306', 3, 'READY'),
    -- Penthouse Suite
    (7, '401', 4, 'READY'),
    (7, '402', 4, 'READY'),
    (7, '403', 4, 'READY');
-- Amenity assignment by tier
-- Single, Double, Twin: basic (1–9, 12, 13)
-- Family: basic + extras (1–10, 12–14)
-- Deluxe: (1–10, 12–15)
-- Suite: all (1–15)
-- Penthouse Suite: all (1–15)

-- Single, Double, Twin
INSERT INTO room_amenity (room_id, amenity_id)
SELECT r.id, a.id
FROM room r
         JOIN room_amenity a ON a.id IN (1,2,3,4,5,6,7,8,9,12,13)
WHERE r.room_type_id IN (1,2,3);
-- Family
INSERT INTO room_amenity (room_id, amenity_id)
SELECT r.id, a.id
FROM room r
         JOIN room_amenity a ON a.id IN (1,2,3,4,5,6,7,8,9,10,12,13,14)
WHERE r.room_type_id = 4;
-- Deluxe
INSERT INTO room_amenity (room_id, amenity_id)
SELECT r.id, a.id
FROM room r
         JOIN room_amenity a ON a.id IN (1,2,3,4,5,6,7,8,9,10,12,13,14,15)
WHERE r.room_type_id = 5;
-- Suite & Penthouse Suite
INSERT INTO room_amenity (room_id, amenity_id)
SELECT r.id, a.id
FROM room r
         JOIN room_amenity a ON a.id BETWEEN 1 AND 15
WHERE r.room_type_id IN (6,7);
