﻿using System.Collections.Generic;
using System.Reflection;
using Chooky.Core.Interfaces;
using Common.Logging;
namespace Chooky.Data.ArcGIS.Desktop
{

    public class ObjectClassDataStore : IObjectClassStore
    {

        /// <summary>
        ///     The Log (Common.Logging)
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


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
