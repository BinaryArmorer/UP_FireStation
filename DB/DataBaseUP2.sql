CREATE TABLE FireTruck 
(
    id_FireTruck SERIAL PRIMARY KEY,
    id_отряда INTEGER,
    Класс VARCHAR(255) NOT NULL,
    Марка VARCHAR(255) NOT NULL,
    Модель VARCHAR(255) NOT NULL,
    Пробег INTEGER NOT NULL,
    Состояние VARCHAR(255) NOT NULL,
    Дата_выпуска DATE NOT NULL,
    Дата_списания DATE
);

CREATE TABLE FireSquad
(
  	id_FireSquad SERIAL PRIMARY KEY,
    Название VARCHAR(255) NOT NULL,
    Статус VARCHAR(255) NOT NULL

);

CREATE TABLE FireMan
(
	id_FireMan SERIAL PRIMARY KEY,
    ID_отряда INTEGER,
    Имя VARCHAR(255) NOT NULL,
    Фамилия VARCHAR(255) NOT NULL,
    Отчество VARCHAR(255) NOT NULL,
    Дата_рождения DATE NOT NULL
);

CREATE TABLE Equipment 
(
  	id_Equipment SERIAL PRIMARY KEY,
    ID_отряда INTEGER,
    Тип VARCHAR(255) NOT NULL,
    Состояние VARCHAR(255) NOT NULL,
    Количество VARCHAR(255) NOT NULL,
    Дата_списания DATE
);

-- FireSquad
INSERT INTO FireSquad (Название, Статус) VALUES
('Отряд №1', 'Активен'),
('Отряд №2', 'Активен'),
('Отряд №3', 'Активен'),
('Отряд №4', 'Резервный'),
('Отряд №5', 'Активен');

-- FireTruck
INSERT INTO FireTruck (id_отряда, Класс, Марка, Модель, Пробег, Состояние, Дата_выпуска, Дата_списания) VALUES
(1, 'А', 'ЗИЛ', '131', 100000, 'Исправен', '2018-05-10', NULL),
(2, 'Б', 'ГАЗ', '3308', 50000, 'В ремонте', '2020-11-15', NULL),
(3, 'А', 'МАЗ', '5336', 150000, 'Исправен', '2015-03-20', '2023-10-26'),
(1, 'Б', 'КАМАЗ', '53229', 80000, 'Исправен', '2019-07-25', NULL),
(4, 'А', 'Урал', '4320', 75000, 'Исправен', '2022-02-01', NULL);


-- FireMan
INSERT INTO FireMan (id_отряда, Имя, Фамилия, Отчество, Дата_рождения) VALUES
(1, 'Иван', 'Иванов', 'Иванович', '1985-03-15'),
(2, 'Петр', 'Петров', 'Петрович', '1990-07-22'),
(3, 'Сидор', 'Сидоров', 'Сидорович', '1978-11-05'),
(1, 'Сергей', 'Сергеев', 'Сергеевич', '1995-01-10'),
(2, 'Андрей', 'Андреев', 'Андреевич', '1988-09-28');

-- Equipment
INSERT INTO Equipment (id_отряда, Тип, Состояние, Количество, Дата_списания) VALUES
(1, 'Лестница', 'Исправно', 2, NULL),
(2, 'Рация', 'Исправно', 5, NULL),
(3, 'Гидрант', 'Исправно', 10, '2024-01-15'),
(1, 'Топор', 'Исправно', 20, NULL),
(2, 'Огнетушитель', 'В ремонте', 15, NULL);

