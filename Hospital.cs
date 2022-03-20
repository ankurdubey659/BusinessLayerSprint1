using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessObjectLayer;
using DALSprint1;
namespace BusinessLayerSprint1
{
    public static class Hospital
    {
        private static readonly Random _random = new Random();


        public static string SetPhysicianId()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            char[] charArray = new char[8];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[_random.Next(0, 35)];
            }
            string resultPhysicianId = new string(charArray);
            return "PN" + resultPhysicianId;
        }
        public static string NewPhysician(Physician objPhysician)
        {
            string status;
            bool isValidEmail = RegularExpression.isValidEmailId(objPhysician.PhysicianEmail);

            if (isValidEmail)
            {
                 status = SendData.AddNewPhysician(objPhysician);
            }
            else
            {
                throw new Exception("Invalid Email-Id");
            }

            return status;
        }
        public static string ModifyPhysicianFirstName(string physicianId, string newUpdate)
        {
            string status = SendData.UpdatePhysicianDetails(physicianId, "FirstName", newUpdate);
            return status;
        }
        public static string ModifyPhysicianMiddleName(string physicianId, string newUpdate)
        {
            string status = SendData.UpdatePhysicianDetails(physicianId, "MiddleName", newUpdate);
            return status;
        }
        public static string ModifyPhysicianLastName(string physicianId, string newUpdate)
        {
            string status = SendData.UpdatePhysicianDetails(physicianId, "LastName", newUpdate);
            return status;
        }
        public static string ModifyPhysicianSpeciality(string physicianId, string newUpdate)
        {

            string status = SendData.UpdatePhysicianDetails(physicianId, "Speciality", newUpdate);
            return status;
        }
        public static string ModifyPhysicianQualification(string physicianId, string newUpdate)
        {
            string status = SendData.UpdatePhysicianDetails(physicianId, "Qualification", newUpdate);
            return status;
        }
        public static string ModifyPhysicianPhoneNumber(string physicianId, long newUpdate)
        {
            string status = SendData.UpdatePhysicianDetails(physicianId, "PhoneNumber", newUpdate.ToString());
            return status;
        }
        public static string ModifyPhysicianEmail(string physicianId, string newUpdate)
        {
            string status;
            bool isValidEmail = RegularExpression.isValidEmailId(newUpdate);
            if (isValidEmail)
            {
                status = SendData.UpdatePhysicianDetails(physicianId, "Email", newUpdate);
            }
            else
            {
                throw new Exception("Invalid Exception");
            }
            return status;
        }
        public static string DeletePhysician(string physicianId)
        {
            string status;
            status = SendData.DeletePhysician(physicianId);
            return status;
        }
        public static List<Physician> FetchAllPhysicians()
        {
            List<Physician> physiciansList = new List<Physician>();
            physiciansList = SendData.SendAllPhysicians();
            return physiciansList;
        }
        public static Physician FetchPhysicianById(string physicianId)
        {
            Physician sendPhysician = SendData.SendPhysicianById(physicianId);
            return sendPhysician;
        }


         
        public static string SetPatientId()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            char[] charArray = new char[8];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[_random.Next(0, 35)];
            }
            string resultPatientId = new string(charArray);
            return "PT" + resultPatientId;
        }
        public static string NewPatient(Patient objPatient)
        {
            string status;

            Hospital.FetchAddress(objPatient.PatientAddressCode);

            status = SendData.AddNewPatient(objPatient);

            return status;
        }
        public static string ModifyPatientFirstName(string patientId, string newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "FirstName", newUpdate);
            return status;
        }
        public static string ModifyPatientMiddleName(string patientId, string newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "MiddleName", newUpdate);
            return status;
        }
        public static string ModifyPatientLastName(string patientId, string newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "LastName", newUpdate);
            return status;
        }
        public static string ModifyPatientAddress(string patientId, string newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "Address", newUpdate);
            return status;
        }
        public static string ModifyPatientDOB(string patientId, DateTime newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "DOB", newUpdate.ToString());
            return status;
        }
        public static string ModifyPatientBMI(string patientId, float newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "BMI", newUpdate.ToString());
            return status;
        }
        public static string ModifyPatientIsDiabetic(string patientId, bool newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "IsDiabetic", newUpdate.ToString());
            return status;
        }
        public static string ModifyPatientMedicalHistory(string patientId, string newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "MedicalHistory", newUpdate);
            return status;
        }
        public static string ModifyPatientPhoneNumber(string patientId, long newUpdate)
        {
            string status = SendData.UpdatePatientDetails(patientId, "PNum", newUpdate.ToString());
            return status;
        }
        public static string DeletePatient(string patientId)
        {
            string status;
            status = SendData.DeletePatient(patientId);
            return status;
        }
        public static List<Patient> FetchAllPatients()
        {
            List<Patient> PatientsList = new List<Patient>();
            PatientsList = SendData.SendAllPatients();        
            return PatientsList;
        }
        public static List<Patient> FetchPatientsByPhoneNumber(long phoneNumber)
        {
            List<Patient> PatientsList = new List<Patient>();
            PatientsList = SendData.SendPatientsByPhoneNo(phoneNumber);
            return PatientsList;
        }
        public static Patient FetchPatientById(string patientId)
        {
            Patient sendPatient = new Patient();
            sendPatient = SendData.SendPatientById(patientId);
            return sendPatient;
        }
        


        public static string SetAddressCode()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            char[] charArray = new char[8];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[_random.Next(0, 35)];
            }
            string resultAddressCode = new string(charArray);
            return "PT" + resultAddressCode;
        }
        public static string SaveAddress(Address objAddress)
        {
            string status = SendData.AddAddress(objAddress);
            return status;
        }
        public static Address FetchAddress(string addressCode)
        {
            Address objAddress = SendData.SendAddressByAddressCode(addressCode);
            return objAddress;
        }



        public static string SetBookingId()
            {
                string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
                char[] charArray = new char[8];
                for (int i = 0; i < charArray.Length; i++)
                {
                    charArray[i] = characters[_random.Next(0, 35)];
                }
                string resultBookingId = new string(charArray);
                return "BK" + resultBookingId;
            }
        public static int GiveAppointmentDate()
        {
            return _random.Next(0, 15);
        }
        public static int GiveAppointmentTime()
        {
            return _random.Next(1, 5);
        }
        public static float GetConsultationFee()
        {
            return (float)(_random.Next(500, 5000) + (_random.NextDouble() * 100));
        }
        public static List<Appointment> FetchAllAppointmentDetails()
        {
            List<Appointment> appointments = new List<Appointment>();
            appointments = SendData.SendAllAppointmentDetails();                
            return appointments;
        }
        public static string FixAppointment(Appointment objAppointment)
            {
                string status;
                Appointment newAppointment = new Appointment();

                status = SendData.NewAppointment(objAppointment);
                return status;
            }
        public static Appointment FetchAppointmentDetails(string bookingId)
            {
                Appointment objAppointment = new Appointment();
                objAppointment = SendData.SendAppointmentDetails(bookingId);                
                return objAppointment;
            }
        public static string CancelAppointment(string bookingId)
            {
                string status = SendData.CancelAppointment(bookingId);
                return status;
            }
        public static string UpdateAllAppointmentStatus()
        {
            string status = SendData.UpdateAppointmentDetails();
            return status;
        }

        

        public static string SetPrescriptionId()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            char[] charArray = new char[8];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[_random.Next(0, 35)];
            }
            string resultPrescriptionId = new string(charArray);
            return "CT" + resultPrescriptionId;
        }
        public static string Consult(Consultation objConsultation)
        {
            string status;
            status = SendData.SaveConsultation(objConsultation);
            return status;
        }
        public static Consultation FetchConsultationSlip(string prescriptionId)
        {
            Consultation consultationSlip = SendData.SendConsultationDetails(prescriptionId);
            return consultationSlip;
        }
    


        public static string SetDrugDosageId()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            char[] charArray = new char[8];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[_random.Next(0, 35)];
            }
            string resultDrugDosageId = new string(charArray);
            return "DD" + resultDrugDosageId;
        }
        public static string AssignDosage(DrugDosage objDrugDosage)
        {
            string status = SendData.SaveDrugDosage(objDrugDosage);
            return status;
        }
        public static DrugDosage FetchDosageById(string dosageId)
        {
            DrugDosage objDrugDosage = SendData.SendDosageById(dosageId);
            return objDrugDosage;
        }
        public static List<Drug> FetchAllDrugsInDosage(string drugDosageId)
        {
            List<Drug> drugsList = SendData.SendAllDrugAndDoseByDrugDosageId(drugDosageId);
            return drugsList;
        }

    

        public static string SetDrugId()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            char[] charArray = new char[8];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[_random.Next(0, 35)];
            }
            string resultDrugId = new string(charArray);
            return "DG" + resultDrugId;
        }
        public static string NewDrug(Drug objDrug)
        {
            SendData.DeleteExpiredDrugs();
            string status;
            status = SendData.AddNewDrug(objDrug);
            return status;
        }
        public static string UpdatePrice(string drugId,float newPrice)
        {
            SendData.DeleteExpiredDrugs();

            string status = SendData.UpdateDrugPrice(drugId, newPrice);
            return status;
        }
        public static List<Drug> FetchAllDrug()
        {
            SendData.DeleteExpiredDrugs();

            List<Drug> drugsList = new List<Drug>();
            drugsList = SendData.SendAllDrugs();

            return drugsList;
            
        }
        public static Drug FetchDrugById(string drugId)
        {
            SendData.DeleteExpiredDrugs();

            List<string> getDrug = new List<string>();
            Drug sendDrug = SendData.SendDrugById(drugId);

            return sendDrug;
        }
        public static string RemoveExpiredDrugs()
        {
            string status = SendData.DeleteExpiredDrugs();
            return status;
        }
        public static string UpdateDrugDosageInvolved(string drugId,string newUpdate)
        {
            SendData.DeleteExpiredDrugs();

            string status = SendData.UpdateDosageDetailsInDrug(drugId, newUpdate);
            return status;
        }
        public static string UpdateDrugDose(string drugId, string newUpdate)
        {
            SendData.DeleteExpiredDrugs();

            string status = SendData.UpdateDrugDoseDetails(drugId, newUpdate);
            return status;
        }
    }
}






