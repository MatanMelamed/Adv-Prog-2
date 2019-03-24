using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {

    public class SingleMission : IMission {

        public const string TYPE = "Single";

        string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        string type;
        public string Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        Mission mission;

        public event EventHandler<double> OnCalculate;

        public SingleMission(Mission newMission, string newName) {
            mission = newMission;
            Name = newName;
            Type = TYPE;
        }

        public double Calculate(double value) {
            value = mission(value);
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
