﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.WinForm.Helpers
{
    public class DataValidation
    {
        private object _instance;
        private string _errorMessage;
        private bool _isValid;

        public DataValidation(object instance)
        {
            _instance = instance;
            Validate();
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }
        public bool Result
        {
            get { return _isValid; }
        }

        private void Validate()
        {            
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(_instance);

            _isValid = Validator.TryValidateObject(_instance, context, results, true);

            if (_isValid == false)
            {
                _errorMessage = "Tiene algunos campos no válidos, realice las correcciones siguientes:\n\n";
                foreach (ValidationResult item in results)
                {
                    _errorMessage += "     ■ " + item.ErrorMessage + "\n";
                }                           
            }         
        }
    }
}
