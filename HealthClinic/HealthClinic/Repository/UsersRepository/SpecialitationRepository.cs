// File:    SpecialitationRepository.cs
// Author:  Stefan
// Created: nedelja, 24. maj 2020. 18:26:58
// Purpose: Definition of Class SpecialitationRepository

using Model.Doctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.UsersRepository
{
    public class SpecialitationRepository : CSVRepository<Specialitation, int>, ISpecialitationRepository
    {
        private string path;

        public SpecialitationRepository(ICSVStream<Specialitation> stream, ISequencer<int> sequencer)
         : base(stream, sequencer)
        {
        }

    }
}