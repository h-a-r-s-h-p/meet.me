//Author: Parmanand Kumar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Server.Persistence
{
    //Persisence Factory
    /// <summary>
    ///     create instances of Summamry or Telemetry Persistence Class respectively
    /// </summary>
    public class PersistenceFactory
    {
            ISummaryPersistence getSummaryPersistenceInstance()
            {
                return new SummaryPersistence();
            }

            ITelemetryPersistence getTelemetryPersistenceInstance()
            {
                return new TelemetryPersistence();
            }

    }

}
