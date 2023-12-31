﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact owner = new Contact("Agustin");
            owner.Phone = "91933109";
            owner.Email = "agustin.pose@correo.ucu.edu.uy";
            
            Phonebook phonebook = new Phonebook(owner);
            
            phonebook.AddContact("Santiago", "95401923", "santiago.leites@correo.ucu.edu.uy");
            phonebook.AddContact("Manu", "92505087", "manuela.guedez@correo.ucu.edu.uy");


            phonebook.SendMessage( "Santiago", "SUIIII");

            phonebook.SendEmail("Manu", "NO TENDRAS MIS DATOS!!!");
            phonebook.SendEmail("Santiago", "NO TENDRAS MIS DATOS!!!");
            
            phonebook.SendSMS("Agustin", "NO TENDRAS MIS DATOS!!!");
        }
    }
}
