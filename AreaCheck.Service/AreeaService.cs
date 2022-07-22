using AreaCheck.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCheck.Service
{
    public  class AreeaService: IAreaService
    {
        public AreeaService()
        {

        }

        public double CalculateArea(AreaModel model)
        {
            var result = model.Lenght * model.Breadth;
            return result;
        }
    }
}
