using System;

namespace BankSys
{

    public abstract class Bank
    {
        public abstract void PrintInfo();
        public abstract bool IsClientByDate(DateTime date);
    }
    public class User : Bank
    {
        public string BankName { get; set; }
        public string Surname { get; set; }
        public uint СardNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public decimal AmountCard { get; set; }

        public User(string bankname, string surname, uint cardNumber, DateTime receiptDate, decimal Amountcard)
        {
            BankName = bankname;
            Surname = surname;
            СardNumber = cardNumber;
            ReceiptDate = receiptDate;
            AmountCard = Amountcard;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Название банка: {0}", BankName);
            Console.WriteLine("ФИО пользователя: {0}", Surname);
            Console.WriteLine("Номер карты: {0}", СardNumber);
            Console.WriteLine("Дата поступления на карту: {0}", ReceiptDate.ToShortDateString());
            Console.WriteLine("Сумма поступления: {0} рублей", AmountCard);
        }
        public override bool IsClientByDate(DateTime date)
        {
            if (ReceiptDate == date)
                return true;
            return false;
        }
    }


    public class Investor : Bank
    {
        public string BankName { get; set; }
        public string Surname { get; set; }
        public uint AccountNumber { get; set; }
        public DateTime DepositDate { get; set; }
        public decimal DepositAmount { get; set; }
        public double DepositInterest { get; set; }

        public Investor(string bankname, string surname, uint accountNumber, DateTime depositDate, decimal depositAmount, double depositInteres)
        {
            BankName = bankname;
            Surname = surname;
            AccountNumber = accountNumber;
            DepositDate = depositDate;
            DepositAmount = depositAmount;
            DepositInterest = depositInteres;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("Название банка: {0}", BankName);
            Console.WriteLine("ФИО вкладчика: {0}", Surname);
            Console.WriteLine("Номер счета: {0}", AccountNumber);
            Console.WriteLine("Дата открытия вклада: {0}", DepositDate.ToShortDateString());
            Console.WriteLine("Размер вклада: {0}", DepositAmount);
            Console.WriteLine("Процент по вкладу: {0}", DepositInterest);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (DepositDate == date)
                return true;
            return false;
        }
    }

    public class Creditor : Bank
    {
        public string BankName { get; set; }
        public string Surname { get; set; }
        public uint AccountNumber { get; set; }
        public DateTime CreditDate { get; set; }
        public decimal CreditAmount { get; set; }
        public double CreditInterest { get; set; }
        public decimal CreditBalance { get; set; }

        public Creditor(string bankname, string surname, uint accountNumber, DateTime creditDate, decimal creditAmount, double creditInterest,
        decimal creditBalance)
        {
            BankName = bankname;
            Surname = surname;
            AccountNumber = accountNumber;
            CreditDate = creditDate;
            CreditAmount = creditAmount;
            CreditInterest = creditInterest;
            CreditBalance = creditBalance;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Название банка: {0}", BankName);
            Console.WriteLine("ФИО вкладчика: {0}", Surname);
            Console.WriteLine("Номер счета: {0}", AccountNumber);
            Console.WriteLine("Дата выдачи кредита: {0}", CreditDate.ToShortDateString());
            Console.WriteLine("Размер кредита: {0}", CreditAmount);
            Console.WriteLine("Процент по кредиту: {0}", CreditInterest);
            Console.WriteLine("Остаток долга: {0}", CreditBalance);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (CreditDate == date)
                return true;
            return false;
        }
    }

    public class Organization : Bank
    {
        public string BankName { get; set; }
        public string Name { get; set; }
        public DateTime AccountDate { get; set; }
        public uint AccountNumber { get; set; }
        public decimal AccountAmount { get; set; }

        public Organization(string bankname, string name, DateTime accountDate, uint accountNumber, decimal accountAmount)
        {
            BankName = bankname;
            Name = name;
            AccountDate = accountDate;
            AccountNumber = accountNumber;
            AccountAmount = accountAmount;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Название банка: {0}", BankName);
            Console.WriteLine("Название организации: {0}", Name);
            Console.WriteLine("Дата открытия счета: {0}", AccountDate.ToShortDateString());
            Console.WriteLine("Номер счета: {0}", AccountNumber);
            Console.WriteLine("Сумма на счету: {0}", AccountAmount);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (AccountDate == date)
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank[] clientDataBase = new Bank[]
            {
new User("Сбер","Злоказов Кирилл Евгеньевич", 2201356514, new DateTime(2022, 4, 2), 123000m),
new User("ПочтаБанк","Ноздрин Виктор Викторович", 122302941, new DateTime(2022, 4, 2), 1021000m),
new Investor("АльфаБанк","Коростелёв Дмитрий Игоревич", 1212415342,new DateTime(2021,5,7), 250178.597m, 20.15),
new Investor("ТинькОфф","Петров Василий Иванович", 1212122365,DateTime.Now, 121378.867m, 18.75),
new Creditor("БанкА","Кобочков Максим Александрович", 121259690,new DateTime(2022, 8, 9), 12178.867m, 18.75, 578.89m),
new Creditor("ПоБанк","Почков Игорь Михайлович", 121221898,new DateTime(2021, 7, 19), 122178.867m, 18.75, 5278.89m),
new Organization("БанкИто","Курток.Нет", new DateTime(2020,2,18), 123456785, 6783512.6723m),
new Organization("НорБанк","ШаурАрмен", new DateTime(2021,3,8), 456456785, 7894623.7834m)
            };

            foreach (Bank client in clientDataBase)
            {
                client.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

