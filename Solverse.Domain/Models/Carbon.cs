using System;
using System.Collections.Generic;

namespace Solverse.Domain.Models
{
    public abstract class AbstractMolecule
    {
        public Guid Id => Guid.NewGuid();
        public List<Bond> Bonds { get; }

        public AbstractMolecule()
        {
            Bonds = new List<Bond>();
        }
    }

    public class Bond
    {
        public AbstractMolecule A { get; }
        public AbstractMolecule B { get; }

        public int Rank { get; }

        public Bond(AbstractMolecule a, AbstractMolecule b, int rank = 1)
        {
            Rank = rank;
            A = a;
            B = b;
        }
    }

    public class Carbon : AbstractMolecule
    {
    }

    public class Oxygen : AbstractMolecule
    {

    }
}
