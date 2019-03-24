using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public delegate double Mission(double d);

    public class FunctionsContainer {

        Dictionary<string, Mission> dictionary;

        public FunctionsContainer() {
            dictionary = new Dictionary<string, Mission>();
        }

        public Mission this[string name] {
            get {
                if (dictionary.ContainsKey(name)) {
                    return dictionary[name];
                }

                dictionary[name] = val => val;
                return dictionary[name];
            }
            set {
                dictionary[name] = value;
            }
        }

        public Dictionary<string, Mission>.KeyCollection getAllMissions() {
            return dictionary.Keys;
        }
    }
}
