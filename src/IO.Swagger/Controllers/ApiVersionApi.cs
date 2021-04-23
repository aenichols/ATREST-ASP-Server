/*
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ApiVersionApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/ATServicesRest/VersionInformation")]
        [ValidateModelState]
        [SwaggerOperation("ApiVersionApiVersionInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(ApiVersionResultModel), description: "OK")]
        public virtual IActionResult ApiVersionApiVersionInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ApiVersionResultModel));

            string exampleJson = null;
            exampleJson = "{\n  \"apiVersions\" : [ \"apiVersions\", \"apiVersions\" ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiVersionResultModel>(exampleJson)
            : default(ApiVersionResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
