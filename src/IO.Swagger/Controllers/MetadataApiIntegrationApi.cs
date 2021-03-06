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
    public class MetadataApiIntegrationApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/EntityInformation")]
        [ValidateModelState]
        [SwaggerOperation("MetadataApiIntegrationQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(GlobalEntityInformationResultModel), description: "OK")]
        public virtual IActionResult MetadataApiIntegrationQueryEntityInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GlobalEntityInformationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"entityDescriptions\" : [ {\n    \"info\" : {\n      \"canUpdate\" : true,\n      \"supportsWebhookCallouts\" : true,\n      \"userAccessForCreate\" : { },\n      \"name\" : \"name\",\n      \"canDelete\" : true,\n      \"canQuery\" : true,\n      \"canCreate\" : true,\n      \"hasUserDefinedFields\" : true\n    }\n  }, {\n    \"info\" : {\n      \"canUpdate\" : true,\n      \"supportsWebhookCallouts\" : true,\n      \"userAccessForCreate\" : { },\n      \"name\" : \"name\",\n      \"canDelete\" : true,\n      \"canQuery\" : true,\n      \"canCreate\" : true,\n      \"hasUserDefinedFields\" : true\n    }\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GlobalEntityInformationResultModel>(exampleJson)
            : default(GlobalEntityInformationResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
