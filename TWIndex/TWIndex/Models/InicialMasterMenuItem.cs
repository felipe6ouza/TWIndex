using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWIndex.Models
{
    public class InicialMasterMenuItem
    {
        public InicialMasterMenuItem()
        {
            TargetType = typeof(InicialMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}