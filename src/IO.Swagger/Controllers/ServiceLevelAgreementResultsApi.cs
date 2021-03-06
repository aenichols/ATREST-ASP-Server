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
    public class ServiceLevelAgreementResultsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="queryModel"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/query")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsQuery([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"resolutionResourceID\" : 9,\n    \"soapParentPropertyId\" : 2,\n    \"firstResponseInitiatingResourceID\" : 1,\n    \"firstResponseElapsedHours\" : 6.027456183070403,\n    \"serviceLevelAgreementName\" : \"serviceLevelAgreementName\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"resolutionPlanElapsedHours\" : 2.3021358869347655,\n    \"isResolutionPlanMet\" : true,\n    \"isFirstResponseMet\" : true,\n    \"id\" : 0,\n    \"firstResponseResourceID\" : 5,\n    \"isResolutionMet\" : true,\n    \"resolutionElapsedHours\" : 5.637376656633329,\n    \"ticketID\" : 3,\n    \"resolutionPlanResourceID\" : 7\n  }, {\n    \"resolutionResourceID\" : 9,\n    \"soapParentPropertyId\" : 2,\n    \"firstResponseInitiatingResourceID\" : 1,\n    \"firstResponseElapsedHours\" : 6.027456183070403,\n    \"serviceLevelAgreementName\" : \"serviceLevelAgreementName\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"resolutionPlanElapsedHours\" : 2.3021358869347655,\n    \"isResolutionPlanMet\" : true,\n    \"isFirstResponseMet\" : true,\n    \"id\" : 0,\n    \"firstResponseResourceID\" : 5,\n    \"isResolutionMet\" : true,\n    \"resolutionElapsedHours\" : 5.637376656633329,\n    \"ticketID\" : 3,\n    \"resolutionPlanResourceID\" : 7\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults>(exampleJson)
            : default(QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="queryModel"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/query/count")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsQueryCount([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryCountResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"queryCount\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryCountResultModel>(exampleJson)
            : default(QueryCountResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

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
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/entityInformation")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(EntityInformationResultModel), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsQueryEntityInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EntityInformationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"info\" : {\n    \"canUpdate\" : true,\n    \"supportsWebhookCallouts\" : true,\n    \"userAccessForCreate\" : { },\n    \"name\" : \"name\",\n    \"canDelete\" : true,\n    \"canQuery\" : true,\n    \"canCreate\" : true,\n    \"hasUserDefinedFields\" : true\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EntityInformationResultModel>(exampleJson)
            : default(EntityInformationResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

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
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/entityInformation/fields")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsQueryFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(FieldInformationResultModel), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsQueryFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(FieldInformationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"fields\" : [ {\n    \"picklistValues\" : [ {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    }, {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    } ],\n    \"isRequired\" : true,\n    \"isReadOnly\" : true,\n    \"picklistParentValueField\" : \"picklistParentValueField\",\n    \"dataType\" : \"dataType\",\n    \"name\" : \"name\",\n    \"length\" : 0,\n    \"isQueryable\" : true,\n    \"isPickList\" : true,\n    \"isReference\" : true,\n    \"referenceEntityType\" : \"referenceEntityType\",\n    \"isSupportedWebhookField\" : { }\n  }, {\n    \"picklistValues\" : [ {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    }, {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    } ],\n    \"isRequired\" : true,\n    \"isReadOnly\" : true,\n    \"picklistParentValueField\" : \"picklistParentValueField\",\n    \"dataType\" : \"dataType\",\n    \"name\" : \"name\",\n    \"length\" : 0,\n    \"isQueryable\" : true,\n    \"isPickList\" : true,\n    \"isReference\" : true,\n    \"referenceEntityType\" : \"referenceEntityType\",\n    \"isSupportedWebhookField\" : { }\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<FieldInformationResultModel>(exampleJson)
            : default(FieldInformationResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ItemQueryResultModelServiceLevelAgreementResultsModelServiceLevelAgreementResults), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsQueryItem([FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ItemQueryResultModelServiceLevelAgreementResultsModelServiceLevelAgreementResults));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"item\" : {\n    \"resolutionResourceID\" : 9,\n    \"soapParentPropertyId\" : 2,\n    \"firstResponseInitiatingResourceID\" : 1,\n    \"firstResponseElapsedHours\" : 6.027456183070403,\n    \"serviceLevelAgreementName\" : \"serviceLevelAgreementName\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"resolutionPlanElapsedHours\" : 2.3021358869347655,\n    \"isResolutionPlanMet\" : true,\n    \"isFirstResponseMet\" : true,\n    \"id\" : 0,\n    \"firstResponseResourceID\" : 5,\n    \"isResolutionMet\" : true,\n    \"resolutionElapsedHours\" : 5.637376656633329,\n    \"ticketID\" : 3,\n    \"resolutionPlanResourceID\" : 7\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemQueryResultModelServiceLevelAgreementResultsModelServiceLevelAgreementResults>(exampleJson)
            : default(ItemQueryResultModelServiceLevelAgreementResultsModelServiceLevelAgreementResults);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

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
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/entityInformation/userDefinedFields")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsQueryUserDefinedFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserDefinedFieldInformationResultModel), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsQueryUserDefinedFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserDefinedFieldInformationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"fields\" : [ {\n    \"picklistValues\" : [ {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    }, {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    } ],\n    \"isRequired\" : true,\n    \"picklistParentValueField\" : \"picklistParentValueField\",\n    \"defaultValue\" : \"defaultValue\",\n    \"length\" : 0,\n    \"isQueryable\" : true,\n    \"isPickList\" : true,\n    \"description\" : \"description\",\n    \"label\" : \"label\",\n    \"type\" : \"type\",\n    \"referenceEntityType\" : \"referenceEntityType\",\n    \"isSupportedWebhookField\" : { },\n    \"isReadOnly\" : true,\n    \"name\" : \"name\",\n    \"isReference\" : true\n  }, {\n    \"picklistValues\" : [ {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    }, {\n      \"isSystem\" : true,\n      \"sortOrder\" : 6,\n      \"label\" : \"label\",\n      \"parentValue\" : \"parentValue\",\n      \"isActive\" : true,\n      \"value\" : \"value\",\n      \"isDefaultValue\" : true\n    } ],\n    \"isRequired\" : true,\n    \"picklistParentValueField\" : \"picklistParentValueField\",\n    \"defaultValue\" : \"defaultValue\",\n    \"length\" : 0,\n    \"isQueryable\" : true,\n    \"isPickList\" : true,\n    \"description\" : \"description\",\n    \"label\" : \"label\",\n    \"type\" : \"type\",\n    \"referenceEntityType\" : \"referenceEntityType\",\n    \"isSupportedWebhookField\" : { },\n    \"isReadOnly\" : true,\n    \"name\" : \"name\",\n    \"isReference\" : true\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserDefinedFieldInformationResultModel>(exampleJson)
            : default(UserDefinedFieldInformationResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="search"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/query")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsUrlParameterQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsUrlParameterQuery([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"resolutionResourceID\" : 9,\n    \"soapParentPropertyId\" : 2,\n    \"firstResponseInitiatingResourceID\" : 1,\n    \"firstResponseElapsedHours\" : 6.027456183070403,\n    \"serviceLevelAgreementName\" : \"serviceLevelAgreementName\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"resolutionPlanElapsedHours\" : 2.3021358869347655,\n    \"isResolutionPlanMet\" : true,\n    \"isFirstResponseMet\" : true,\n    \"id\" : 0,\n    \"firstResponseResourceID\" : 5,\n    \"isResolutionMet\" : true,\n    \"resolutionElapsedHours\" : 5.637376656633329,\n    \"ticketID\" : 3,\n    \"resolutionPlanResourceID\" : 7\n  }, {\n    \"resolutionResourceID\" : 9,\n    \"soapParentPropertyId\" : 2,\n    \"firstResponseInitiatingResourceID\" : 1,\n    \"firstResponseElapsedHours\" : 6.027456183070403,\n    \"serviceLevelAgreementName\" : \"serviceLevelAgreementName\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"resolutionPlanElapsedHours\" : 2.3021358869347655,\n    \"isResolutionPlanMet\" : true,\n    \"isFirstResponseMet\" : true,\n    \"id\" : 0,\n    \"firstResponseResourceID\" : 5,\n    \"isResolutionMet\" : true,\n    \"resolutionElapsedHours\" : 5.637376656633329,\n    \"ticketID\" : 3,\n    \"resolutionPlanResourceID\" : 7\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults>(exampleJson)
            : default(QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="search"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/ServiceLevelAgreementResults/query/count")]
        [ValidateModelState]
        [SwaggerOperation("ServiceLevelAgreementResultsUrlParameterQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult ServiceLevelAgreementResultsUrlParameterQueryCount([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryCountResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"queryCount\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryCountResultModel>(exampleJson)
            : default(QueryCountResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
