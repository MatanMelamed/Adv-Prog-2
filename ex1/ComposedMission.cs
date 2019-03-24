using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public class ComposedMission : IMission {

        public const string TYPE = "Composed";

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

        List<Mission> allMissions;

        public event EventHandler<double> OnCalculate;

        public ComposedMission(string newName) {
            Name = newName;
            Type = TYPE;
            allMissions = new List<Mission>();
        }

        public ComposedMission Add(Mission newMission) {
            allMissions.Add(newMission);
            return this;
        }

        public double Calculate(double value) {
            foreach (Mission mission in allMissions) {
                value = mission(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
