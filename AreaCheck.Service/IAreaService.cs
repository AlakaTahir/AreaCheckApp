using AreaCheck.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCheck.Service
{
    public interface IAreaService
    {
        double CalculateArea(AreaModel model);
    }
}
