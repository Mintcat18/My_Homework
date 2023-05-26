with open('data_first_variant.csv', 'a', encoding='utf-8') as file:
    file.write(f'{name}\n{surname}\n{phone}\n{address}\n\n')

# menu = ['first name', 'last name', 'number']
# save = ["Иванов", "Иван", "89159999999"]
# memory = ["Долгов", "Андрей", "89569999999"]
# menu = ['first name', 'last name', 'number']
dict = {1: ["Иванов", "Иван", "89159999999"], 2:["Долгов", "Андрей", "89569995566"]}
for i in dict:
    #print(dict[i])
    for j in range(3):
        if "Дол" in dict[i][j]:
    #print(dict[i][0])
            #if dict[i][0]== "Иванов":
            print(dict[i])
print("Здавствуйте")
print("Вывести телефонную книжку-1")
print("1 Показать записи")
print("2 Добавить записи")
print("3 Добавить номер телефона")
print("Введите число от 1 до 3")
n = input()
if n == "1":
    print(dict)
if n == "2":
    print(dict)
    