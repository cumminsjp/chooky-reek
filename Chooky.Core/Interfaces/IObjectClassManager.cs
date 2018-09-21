using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chooky.Core.Interfaces
{
    public interface IObjectClassStore
    {
        /// <summary>
        /// Gets all of the ObjectID values for a featureclass or table
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <returns></returns>
        IEnumerable<long> GetObjectIds(string className);
    }

}
