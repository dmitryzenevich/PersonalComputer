# PersonalComputer
PersonalComputer
Вариант 1. Персональные компьютеры.
1.	Включение/перезагрузка компьютера.
2.	Установка пользовательского приложения в компьютерном классе.
3.	Продажа компьютеров.
4.	Замена материнской платы.
5.	Сбор металлолома.

1.	Выделение уровней абстракции в системе.

ComputerComponent
OperationSystem
IProduct
Person
UserPC

2.	Выделение базовых сущностей предметной области.
ComputerClass
PersonalComputer
	ComputerCase
	Motherboard
	CPU
	OperationSystems: Windows, Linux, MacOS
	Application
TechnicalSpecialist
User
ComputerShop
Customer
ScrapMetalCollectionSystem

3.	Построение иерархии сущностей.
Показана на диаграмме классов.
4.	Отношения между сущностями.
5.	Демонстрация инкапсуляции, наследования и полиморфизма в решениях задач.
Пример инкапсуляции при установле приложения на компьютер - юзер устанавливает приложение на компьютер,
компьютер вызывает метод у операционной системы "установить приложение",
затем в операционной системе в зависимости от её типа происходит установка приложения.
Пользователь не знает как происходит дальнейшая установка приложения.
Здесь так же продемонстрирован полиморфизм в виде установки приложения на разных ОС,
и наследование - конкретные операционные системы наследуются от класса "операционная система".
6.	Словесное обоснование решений, принятых при построении иерархии:
a.	Уровень абстракции, на которым зада решена.
b.	Какие сущности из иерархии использованы и с какой целью.
	Использована сущность "пользователь" включения/перезагрузки компьютера.
	Использована сущность "компьютерный класс" для создания массива компьютеров.
	Также сущность "пользователь" использована для установки пользовательского приложения.
	Создана сущность "компьютерный магазин" для продажи компьютеров.
	Создаа сущность "покупатель" для покупки компьютера.
	Создана сущность "технический специалист" для замены материнской платы.
	Создана сущность "система сбора металлолома" для утилизации сломанных компонентов компьютера.
c.	Плюсы и минусы выбранного решения.
d.	Обоснование дополнительных архитектурных решений, если таковые были использованы для конкретной задачи.
