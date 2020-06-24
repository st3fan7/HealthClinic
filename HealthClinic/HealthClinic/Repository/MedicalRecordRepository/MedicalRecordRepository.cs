/***********************************************************************
 * Module:  MedicalRecordRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.MedicalRecordRepository
 ***********************************************************************/

using Model.AllActors;
using Model.PatientDoctor;
using Repository.Csv;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.MedicalRecordRepository
{
    public class MedicalRecordRepository : CSVRepository<MedicalRecord, int>, IMedicalRecordRepository
    {

        private const string MEDICALRECORD_FILE = "../../Resources/Data/medicalrecords.csv";
        private static MedicalRecordRepository instance;

        public static MedicalRecordRepository Instance()
        {
            if (instance == null)
            {
                instance = new MedicalRecordRepository(
               new CSVStream<MedicalRecord>(MEDICALRECORD_FILE, new MedicalRecordCSVConverter(",")),
               new IntSequencer());
            }
            return instance;

        }

        public MedicalRecordRepository(ICSVStream<MedicalRecord> stream, ISequencer<int> sequencer)
           : base(stream, sequencer)
        {
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}