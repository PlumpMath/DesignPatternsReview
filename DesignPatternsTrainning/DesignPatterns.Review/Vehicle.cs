using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Review
{
    public abstract class Vehicle
    {
        public string Model { get;private set; }
        private GoAlgorithm _GoAlgorithm;
        public Vehicle(string model)
        {
            Model = model;
        }

        /// <summary>
        /// set the algorithm 
        /// </summary>
        /// <param name="goAlgorithm"></param>
        public void SetGoAlgorithm(GoAlgorithm goAlgorithm)
        {
            _GoAlgorithm = goAlgorithm;
        }

        virtual public void Go()
        {
            _GoAlgorithm.Go(this);
            //Console.WriteLine("Model : {0} , Is driving", Model);
        }
    }

    public class RaceCar : Vehicle
    {
        public RaceCar(string model):base (model)
        {
            // Using an algorithm
            base.SetGoAlgorithm(new GoByDrivingAlgorithm());
        }
    }

    public class Airplane: Vehicle
    {
        public Airplane(string model): base(model)
        {
            SetGoAlgorithm(new GoByFlying());
        }
    }

    public class Jet : Vehicle
    {
        public Jet(string model) : base(model)
        {
            SetGoAlgorithm(new GoByFlyingFast());
        }
    }

    /// <summary>
    /// With inheritance base classes and derived classes have "Is a" relationship
    /// but you're going to  run up against maintenance issues in the future
    /// With composites, you select and use the objects you want, insetead of having 
    /// a rigid hard-coded internal way of doing things, that gives you a "HAS-A" relationship
    /// When planning for changes, consider HAS-A insteod of IS-A relationships
    /// </summary>
    public abstract class GoAlgorithm
    {
        public abstract void Go(Vehicle vehicle);
    }

    /// <summary>
    /// Creating a set of algorithms for volatile code
    /// To make sure that all algorithms implement the same methods, we need to create an interface
    /// </summary>
    public class GoByDrivingAlgorithm: GoAlgorithm
    {
        public override void Go(Vehicle vehicle)
        {
            Console.WriteLine(" {0} I am driving ", vehicle.Model);
        }

    }

    public class GoByFlying : GoAlgorithm
    {
        public override void Go(Vehicle vehicle)
        {
            Console.WriteLine("{0} : I am flying", vehicle.Model);
        }
    }

    public class GoByFlyingFast : GoAlgorithm
    {
        public override void Go(Vehicle vehicle)
        {
            Console.WriteLine("{0} I am flying very fast", vehicle.Model);
        }
    }

}
