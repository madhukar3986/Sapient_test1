using Sapient_Core.Interfaces;
using Sapient_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient_Service
{
    public class MedicineService:IMedicineService
    {
        private readonly IMedicineRepo _medicineRepo;
        public MedicineService(IMedicineRepo medicineRepo)
        {
            _medicineRepo = medicineRepo;
        }

        public void DeleteMedicineInfo()
        {
            _medicineRepo.DeleteMedicineInfo();
        }

        public void EditMedicineInfo()
        {
            _medicineRepo.EditMedicineInfo();
        }

        public IEnumerable<Medicines> GetAllMedicines()
        {
            return _medicineRepo.GetAllMedicines();
        }

        public Medicines GetmedicineByName()
        {
            return _medicineRepo.GetmedicineByName();
        }

        public void SaveMedicineInfo()
        {
            _medicineRepo.SaveMedicineInfo();
        }
    }
}
