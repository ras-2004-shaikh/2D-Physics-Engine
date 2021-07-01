using System;
using System.Collections.Generic;
using System.Collections;

namespace _2D_Physics_Engine
{
    class Program
    {
        static void Main(string[] args) 
        {

        }
    }
    class Interaction 
    {
        public double friction_coeff, restitution_coeff;
        public Material M1, M2;
        public Interaction(Material M1,Material M2, double friction_coeff,double restitution_coeff) 
        {
            this.M1 = M1;
            this.M2 = M2;
            this.friction_coeff = friction_coeff;
            this.restitution_coeff = restitution_coeff;
        }
    }
    class Material 
    {
        private static List<Material> universe_materials = new List<Material>();
        private List<Interaction> interactions;
        public Material() 
        {
            universe_materials.Add(this);
            interactions = new List<Interaction>();
        }
        public Interaction New_Interaction(Material other,double friction_coeff,double restitution_coeff) 
        {
            Interaction new_interaction = new Interaction(this, other, friction_coeff, restitution_coeff);
            this.interactions.Add(new_interaction);
            other.interactions.Add(new_interaction);
            return new_interaction;
        }
    }
    class MacroWorld 
    {
        private double gravity_accn;

        public MacroWorld() 
        {

        }
    }
}
