using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Data
{
    public class LookUpTable
    {
        public IEnumerable<ModelMake> modelMake { get; set; }
        public IEnumerable<PremiumType> premiumType { get; set; }
    }
}
public class ModelMake
{
    public int Id { get; set; }
    public string CarModel { get; set; }
    public string CardMake { get; set; }
}
public class PremiumType
{
    public int Id { get; set; }
    public string Premium { get; set; }
    public string PremType { get; set; }
}