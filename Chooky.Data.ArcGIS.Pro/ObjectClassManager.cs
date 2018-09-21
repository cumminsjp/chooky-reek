using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chooky.Core.Interfaces;

namespace Chooky.Data.ArcGIS.Pro
{

    public class ObjectClassDataStore : IObjectClassStore
    {
        /// <summary>
        /// Gets all of the ObjectID values for a featureclass or table
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <returns></returns>
        public IEnumerable<long> GetObjectIds(string className)
        {


            return new List<long>();
        }
    }
}
