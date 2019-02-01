using System;
using System.Collections.Generic;
using System.Text;
using FixacaoEnumComp01.Entities;
using FixacaoEnumComp01.Entities.Enums;

namespace FixacaoEnumComp01.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        public override string ToString()
        {
            return  Name
                + ", ("
                + Date.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
