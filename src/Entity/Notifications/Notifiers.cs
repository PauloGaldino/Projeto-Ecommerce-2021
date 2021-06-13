﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Notifications
{
    /// <summary>
    /// Clasee resposávl por enviar 
    /// mensagens de erro e validações para a controller
    /// </summary>

    public class Notifiers
    {
        //=============Construtor da classe=============
        public Notifiers()
        {
            Notifications = new List<Notifiers>();
        }

        //===============Propriedades==================

        [NotMapped] //Esta coluna não existe no banco de dados para ser herdada
        public string PropertyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifiers> Notifications { get; set; }

        //=============Nétodos============================

        // método para validar a string
        public bool ValidateStringProperties(string value, string propertyMane)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyMane))
            {
                Notifications.Add(new Notifiers
                {
                    Message = " Este campo é obrigatório.",
                    PropertyName = propertyMane
                });

                return false;
            }
            return true;
        }

        // método para validar a propriedade inteiro
        public bool ValidateIntProperties(int value, string propertyMane)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyMane))
            {
                Notifications.Add(new Notifiers
                {
                    Message = " O valor deste campo deve ser maior que 0.",
                    PropertyName = propertyMane
                });

                return false;
            }
            return true;
        }

        // método para validar a propriedade decimal
        public bool ValidateDecimaProperties(decimal value, string propertyMane)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyMane))
            {
                Notifications.Add(new Notifiers
                {
                    Message = " O valor deste campo deve ser maior que 0.",
                    PropertyName = propertyMane
                });

                return false;
            }
            return true;
        }

    }
}
