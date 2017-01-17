using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Collections.Specialized;
using CRUDImoestudante.App_Data;

namespace CRUDImoestudante
{
    public class APIKeyAuthorization : ServiceAuthenticationManager
    {
        public const string APIKEY = "APIKey";
        public const string APIKEYLIST = "APIKeyList";

        //public List<Guid> APIKeys
        //{
        //    get
        //    {
        //        // Get from the cache
        //        // Could also use AppFabric cache for scalability
        //        var keys = HttpContext.Current.Cache[APIKEYLIST] as List<Guid>;

        //        if (keys == null)
        //            keys = PopulateAPIKeys();

        //        return keys;
        //    }
        //}


        //List<Guid> PopulateAPIKeys()
        //{
        //    List<Guid> r = new List<Guid>();

        //    using (ImoEstudanteEntities db = new ImoEstudanteEntities())
        //    {
        //        foreach (user x in db.users)
        //            if (x.apiKey != null) r.Add(new Guid(x.apiKey));
        //    }
        //    return r;
        //}


        //public string GetAPIKey(OperationContext operationContext)
        //{
        //    // Get the request message
        //    var request = operationContext.RequestContext.RequestMessage;

        //    // Get the HTTP Request
        //    var requestProp = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];

        //    // Get the query string
        //    NameValueCollection queryParams = HttpUtility.ParseQueryString(requestProp.QueryString);

        //    // Return the API key (if present, null if not)
        //    return queryParams[APIKEY];
        //}


        //public bool IsValidAPIKey(OperationContext operationContext)
        //{
        //    // if verification is disabled, return true
        //    if (global.APIKeyVerification == false)
        //        return true;

        //    string key = GetAPIKey(operationContext);

        //    Guid apiKey;

        //    // Convert the string into a Guid and validate it
        //    if (Guid.TryParse(key, out apiKey) && APIKeys.Contains(apiKey))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        // Send back an HTML reply
        //        CreateErrorReply(operationContext, key);
        //        return false;
        //    }
        //}



        //protected override bool CheckAccessCore(OperationContext operationContext)
        //{
        //    return IsValidAPIKey(operationContext);
        //}

    }
}