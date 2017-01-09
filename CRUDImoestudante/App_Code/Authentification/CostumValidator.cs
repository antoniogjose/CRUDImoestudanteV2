using CRUDImoestudante.App_Data;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;

namespace CRUDImoestudante.App_Code.Authentification
{
    public class CostumValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (Authenticate(userName, password))
                return;
            throw new WebFaultException<string>("User Not Found", HttpStatusCode.NotFound);
        }

        public bool Authenticate(string user, string password)
        {
            using (ImoEstudanteEntities db = new ImoEstudanteEntities())
            {
                return db.users.Count(acc => acc.login == user && acc.password == password) > 0;
            }

        }
    }
}