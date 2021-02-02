using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInstancesAndConstructors
{
    class Kontakt
    {
        // Exempel på relevant data att ha i en kontakt klass.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        // Exempel på irellevanta data att ha i en kontakt klass.
        public int Height { get; set; }
        public int Weight { get; set; }
        public int MyProperty { get; set; }
    }
}
