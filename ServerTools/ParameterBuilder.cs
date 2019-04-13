using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
    public class ParameterBuilder
    {
        public int MaximizeMemory { get; set; }
        public int MinimizeMemory { get; set; }
        public ParameterBuilder(int _maxm,int _minm)
        {
            MaximizeMemory = _maxm;
            MinimizeMemory = _minm;
        }
        public string Build(string parameter,string ServerJarName)
        {
            var parameters = $"java -server -Xms{MinimizeMemory}M -Xmx{MaximizeMemory}M {parameter} -jar {ServerJarName} nogui pause";
            return parameters;
        }
    }
}
