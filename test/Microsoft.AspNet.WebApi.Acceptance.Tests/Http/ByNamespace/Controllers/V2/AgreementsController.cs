﻿namespace Microsoft.Web.Http.ByNamespace.Controllers.V2
{
    using Microsoft.Web.Http;
    using Models;
    using System.Web.Http;

    [ApiVersion( "2.0" )]
    public class AgreementsController : ApiController
    {
        public IHttpActionResult Get( string accountId ) => Ok( new Agreement( GetType().FullName, accountId, Request.GetRequestedApiVersion().ToString() ) );
    }
}