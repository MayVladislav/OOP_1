package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Банк мойБанк = Банк.Инициализация();
        System.out.println("Банк готов к работе");
        System.out.println("Идентификация клиента");
        System.out.print("ФИО> ");
        String фиоК = sc.nextLine();
        System.out.print("Номер счета > ");
        String номерК = sc.next();
        System.out.print("Сумма зарплаты > ");
        int зарплатаК = Integer.parseInt(sc.next());
        Клиент клиент = new Клиент(фиоК,номерК,зарплатаК);
        int операция = 0;

        do
        {
            System.out.println("выбор действия\n" + "1 каталог\n"+
                    "2 запрос кредита\n" + "3 закрытие кредита \n");
            операция = sc.nextInt();
            switch (операция)
            {
                case 1: мойБанк.Каталог(); break;
                case 2: System.out.print("Ставка кредита > ");
                String ставкаКредита = sc.next();
                мойБанк.ВыдачаКредита(ставкаКредита, клиент);
                break;
                case 3: мойБанк.ВозвратКредита(клиент);
                break;
                default: break;
            }
        } while (операция != 0);
        sc.close();
        System.out.println("Работа завершена");
    }
}
