using System;

namespace MobileLibraryew
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public readonly string ContractNumber;

        public string TariffName { get; set; }
        public PaymentType PaymentKind { get; set; }
        public decimal Balance { get; set; }

        public Subscriber(string name, string surname, string phoneNumber, string contractNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            ContractNumber = contractNumber;

            TariffName = "Базовый";
            PaymentKind = PaymentType.Prepaid;
            Balance = 0;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Surname} {Name} (тел: {PhoneNumber})";
            string pType = (PaymentKind == PaymentType.Prepaid) ? "Предоплата" : "В кредит";
            info[1] = $"Договор: {ContractNumber}. Тариф: {TariffName}. Тип оплаты: {pType}. Баланс: {Balance} руб.";
            return info;
        }
    }
}
