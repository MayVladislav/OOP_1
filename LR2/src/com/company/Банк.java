package com.company;

import java.util.Hashtable;
import java.util.Map;
import java.util.Optional;
import java.util.Vector;

public class Банк
{
    Hashtable<Кредит, Vector<Клиент>> кредиты =
            new Hashtable<Кредит, Vector<Клиент>>();

    private Банк() {}

    public static  Банк Инициализация() {
        Банк res = new Банк();
        Кредит новый = new Кредит();
        новый.ставкам = "5000";
        //новый.жанр = Жанр.Детектив;
        новый.код = "001";
        новый.названиеКредита = "Выгодный";
        новый.состояние = Состояние.Доступен;

        res.кредиты.put(новый,
                new Vector<>());

        новый = new Кредит();
        новый.ставкам = "10000";
        //новый.жанр = Жанр.Детектив;
        новый.код = "002";
        новый.названиеКредита = "Доступный";
        новый.состояние = Состояние.Доступен;

        res.кредиты.put(новый,
                new Vector<>());

        новый = new Кредит();
        новый.ставкам = "1000";
        //новый.жанр = Жанр.Детектив;
        новый.код = "003";
        новый.названиеКредита = "Доступный";
        новый.состояние = Состояние.НеДоступен;

        res.кредиты.put(новый,
                new Vector<>());

        return res;
    }
        public void ВыдачаКредита(String ставкаКредита, Клиент клиент)
        {

            Optional<Map.Entry<Кредит, Vector<Клиент>>> find =
                    кредиты.entrySet().stream()
                            .filter(e->e.getKey().ставкам.equals(ставкаКредита)).findFirst();

            if (find.isPresent())
            {
                if (find.get().getKey().состояние == Состояние.Доступен && Integer.parseInt(ставкаКредита)<клиент.зарплата)
                {
                    find.get().getKey().состояние = Состояние.НеДоступен;
                    find.get().getValue().add(клиент);
                    System.out.println("Кредит одобрен");
                }
                else
                {
                    System.out.println("Кредит не одобрен или недоступен");
                }
            }
            else
            {
                System.out.println("Такого кредита нет");
            }
        }

        public void ВозвратКредита(Клиент клиент)
        {
            System.out.println("Функция не реализована");
        }

        public void Каталог()
        {
            кредиты.entrySet().stream().forEach(e->{
                Кредит tek = e.getKey();
                System.out.println(tek.названиеКредита + "\n"+
                        tek.ставкам + "\n" + tek.код + "\n");
            });
        }

}
