using System;
using System.Collections.Generic;
using System.Text;
using Sapient_Core.Interfaces;
using Sapient_Core.Models;

namespace Sapient_Service
{
    public interface IMedicineService
    {
        IEnumerable<Medicines> GetAllMedicines();
        Medicines GetmedicineByName();
        void SaveMedicineInfo();
        void EditMedicineInfo();
        void DeleteMedicineInfo();
    }
}
