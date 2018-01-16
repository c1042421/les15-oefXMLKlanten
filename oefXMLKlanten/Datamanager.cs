using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefXMLKlanten
{
    class Datamanager
    {
        public static List<Klanten> getAllKlanten()
        {
            try
            {
                using (var entities = new KlantenEntities())
                {
                    var query = from Klanten in entities.Klantens select Klanten;

                    return query.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
