using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Car
    {
        private string licenseNumber;
        private string color;

        public string GetColor()
        {
            switch (color)
            {
                case "red": { return "röd"; }
                case "green": { return "grön"; }
                case "blue": { return "blå"; }
                case "yellow": { return "yellow"; }
                default: { return ""; }
            }
        }

        public void SetColor(string value)
        {
            if (value.ToLower() == "red" || value.ToLower() == "green" || value.ToLower() == "blue" || value.ToLower() == "yellow")
                color = value.ToLower();
            else
                throw new FormatException("ERROR: Invalid input. Must be a string and value equal to \"red\", \"green\", \"blue\" or \"yellow\".");
        }

        public string GetLicenseNumber()
        {
            if (licenseNumber != null)
                return $"***{licenseNumber}***".ToUpper();
            return "";
        }

        public void SetLicenseNumber(string value)
        {
            
            bool isValid = (value.Length == 6);
            if (isValid)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (i < 3)
                    {
                        if (!Char.IsLetter(value[i]))
                            isValid = false;
                    }
                    else
                        if (!Char.IsNumber(value[i]))
                        isValid = false;
                }
            }

            var forbidden = new string[] { "ufo", "får", "oxå" };

            foreach (var word in forbidden)
            {
                if (value.Substring(0, 3) == word)
                    throw new Exception("ERROR: Forbidden word found in license plate string.");
            }

            if (isValid)
                licenseNumber = value;

            else
                throw new FormatException("ERROR: Invalid input. Must be a string of format ABC123.");
        }
    }
}
