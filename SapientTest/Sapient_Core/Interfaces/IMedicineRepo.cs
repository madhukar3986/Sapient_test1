using Sapient_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient_Core.Interfaces
{
    public interface IMedicineRepo
    {
       IEnumerable<Medicines> GetAllMedicines();
        Medicines GetmedicineByName();
        void SaveMedicineInfo();
        void EditMedicineInfo();
        void DeleteMedicineInfo();
    }
}
