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
    public class TimeEntriesApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="restModelInput"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/ATServicesRest/V1.0/TimeEntries")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesCreateEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesCreateEntity([FromBody]TimeEntryModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OperationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"itemId\" : { }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OperationResultModel>(exampleJson)
            : default(OperationResultModel);
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
        [HttpDelete]
        [Route("/ATServicesRest/V1.0/TimeEntries/{id}")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesDeleteEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesDeleteEntity([FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OperationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"itemId\" : { }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OperationResultModel>(exampleJson)
            : default(OperationResultModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="restModelInput"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPatch]
        [Route("/ATServicesRest/V1.0/TimeEntries")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesPatchEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesPatchEntity([FromBody]TimeEntryModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OperationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"itemId\" : { }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OperationResultModel>(exampleJson)
            : default(OperationResultModel);
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
        [Route("/ATServicesRest/V1.0/TimeEntries/query")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultTimeEntryModelTimeEntry), description: "OK")]
        public virtual IActionResult TimeEntriesQuery([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultTimeEntryModelTimeEntry));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"billingApprovalLevelMostRecent\" : 6,\n    \"impersonatorCreatorResourceID\" : 4,\n    \"billingApprovalResourceID\" : 1,\n    \"lastModifiedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"roleID\" : 7,\n    \"billingApprovalDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"timeEntryType\" : 5,\n    \"showOnInvoice\" : true,\n    \"contractID\" : 5,\n    \"internalBillingCodeID\" : 1,\n    \"id\" : 0,\n    \"isNonBillable\" : true,\n    \"hoursToBill\" : 3.616076749251911,\n    \"hoursWorked\" : 2.027123023002322,\n    \"taskID\" : 1,\n    \"ticketID\" : 4,\n    \"creatorUserID\" : 9,\n    \"resourceID\" : 6,\n    \"contractServiceID\" : 7,\n    \"contractServiceBundleID\" : 2,\n    \"impersonatorUpdaterResourceID\" : 7,\n    \"internalNotes\" : \"internalNotes\",\n    \"endDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"billingCodeID\" : 5,\n    \"startDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"offsetHours\" : 1.4894159098541704,\n    \"summaryNotes\" : \"summaryNotes\",\n    \"lastModifiedUserID\" : 1,\n    \"dateWorked\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"billingApprovalLevelMostRecent\" : 6,\n    \"impersonatorCreatorResourceID\" : 4,\n    \"billingApprovalResourceID\" : 1,\n    \"lastModifiedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"roleID\" : 7,\n    \"billingApprovalDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"timeEntryType\" : 5,\n    \"showOnInvoice\" : true,\n    \"contractID\" : 5,\n    \"internalBillingCodeID\" : 1,\n    \"id\" : 0,\n    \"isNonBillable\" : true,\n    \"hoursToBill\" : 3.616076749251911,\n    \"hoursWorked\" : 2.027123023002322,\n    \"taskID\" : 1,\n    \"ticketID\" : 4,\n    \"creatorUserID\" : 9,\n    \"resourceID\" : 6,\n    \"contractServiceID\" : 7,\n    \"contractServiceBundleID\" : 2,\n    \"impersonatorUpdaterResourceID\" : 7,\n    \"internalNotes\" : \"internalNotes\",\n    \"endDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"billingCodeID\" : 5,\n    \"startDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"offsetHours\" : 1.4894159098541704,\n    \"summaryNotes\" : \"summaryNotes\",\n    \"lastModifiedUserID\" : 1,\n    \"dateWorked\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultTimeEntryModelTimeEntry>(exampleJson)
            : default(QueryActionResultTimeEntryModelTimeEntry);
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
        [Route("/ATServicesRest/V1.0/TimeEntries/query/count")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesQueryCount([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/TimeEntries/entityInformation")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(EntityInformationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesQueryEntityInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/TimeEntries/entityInformation/fields")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesQueryFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(FieldInformationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesQueryFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/TimeEntries/{id}")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ItemQueryResultModelTimeEntryModelTimeEntry), description: "OK")]
        public virtual IActionResult TimeEntriesQueryItem([FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ItemQueryResultModelTimeEntryModelTimeEntry));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"item\" : {\n    \"billingApprovalLevelMostRecent\" : 6,\n    \"impersonatorCreatorResourceID\" : 4,\n    \"billingApprovalResourceID\" : 1,\n    \"lastModifiedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"roleID\" : 7,\n    \"billingApprovalDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"timeEntryType\" : 5,\n    \"showOnInvoice\" : true,\n    \"contractID\" : 5,\n    \"internalBillingCodeID\" : 1,\n    \"id\" : 0,\n    \"isNonBillable\" : true,\n    \"hoursToBill\" : 3.616076749251911,\n    \"hoursWorked\" : 2.027123023002322,\n    \"taskID\" : 1,\n    \"ticketID\" : 4,\n    \"creatorUserID\" : 9,\n    \"resourceID\" : 6,\n    \"contractServiceID\" : 7,\n    \"contractServiceBundleID\" : 2,\n    \"impersonatorUpdaterResourceID\" : 7,\n    \"internalNotes\" : \"internalNotes\",\n    \"endDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"billingCodeID\" : 5,\n    \"startDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"offsetHours\" : 1.4894159098541704,\n    \"summaryNotes\" : \"summaryNotes\",\n    \"lastModifiedUserID\" : 1,\n    \"dateWorked\" : \"2000-01-23T04:56:07.000+00:00\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemQueryResultModelTimeEntryModelTimeEntry>(exampleJson)
            : default(ItemQueryResultModelTimeEntryModelTimeEntry);
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
        [Route("/ATServicesRest/V1.0/TimeEntries/entityInformation/userDefinedFields")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesQueryUserDefinedFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserDefinedFieldInformationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesQueryUserDefinedFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        
        /// <param name="restModelInput"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPut]
        [Route("/ATServicesRest/V1.0/TimeEntries")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesUpdateEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesUpdateEntity([FromBody]TimeEntryModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OperationResultModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"itemId\" : { }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OperationResultModel>(exampleJson)
            : default(OperationResultModel);
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
        [Route("/ATServicesRest/V1.0/TimeEntries/query")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesUrlParameterQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultTimeEntryModelTimeEntry), description: "OK")]
        public virtual IActionResult TimeEntriesUrlParameterQuery([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultTimeEntryModelTimeEntry));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"billingApprovalLevelMostRecent\" : 6,\n    \"impersonatorCreatorResourceID\" : 4,\n    \"billingApprovalResourceID\" : 1,\n    \"lastModifiedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"roleID\" : 7,\n    \"billingApprovalDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"timeEntryType\" : 5,\n    \"showOnInvoice\" : true,\n    \"contractID\" : 5,\n    \"internalBillingCodeID\" : 1,\n    \"id\" : 0,\n    \"isNonBillable\" : true,\n    \"hoursToBill\" : 3.616076749251911,\n    \"hoursWorked\" : 2.027123023002322,\n    \"taskID\" : 1,\n    \"ticketID\" : 4,\n    \"creatorUserID\" : 9,\n    \"resourceID\" : 6,\n    \"contractServiceID\" : 7,\n    \"contractServiceBundleID\" : 2,\n    \"impersonatorUpdaterResourceID\" : 7,\n    \"internalNotes\" : \"internalNotes\",\n    \"endDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"billingCodeID\" : 5,\n    \"startDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"offsetHours\" : 1.4894159098541704,\n    \"summaryNotes\" : \"summaryNotes\",\n    \"lastModifiedUserID\" : 1,\n    \"dateWorked\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"billingApprovalLevelMostRecent\" : 6,\n    \"impersonatorCreatorResourceID\" : 4,\n    \"billingApprovalResourceID\" : 1,\n    \"lastModifiedDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"roleID\" : 7,\n    \"billingApprovalDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"timeEntryType\" : 5,\n    \"showOnInvoice\" : true,\n    \"contractID\" : 5,\n    \"internalBillingCodeID\" : 1,\n    \"id\" : 0,\n    \"isNonBillable\" : true,\n    \"hoursToBill\" : 3.616076749251911,\n    \"hoursWorked\" : 2.027123023002322,\n    \"taskID\" : 1,\n    \"ticketID\" : 4,\n    \"creatorUserID\" : 9,\n    \"resourceID\" : 6,\n    \"contractServiceID\" : 7,\n    \"contractServiceBundleID\" : 2,\n    \"impersonatorUpdaterResourceID\" : 7,\n    \"internalNotes\" : \"internalNotes\",\n    \"endDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"billingCodeID\" : 5,\n    \"startDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"offsetHours\" : 1.4894159098541704,\n    \"summaryNotes\" : \"summaryNotes\",\n    \"lastModifiedUserID\" : 1,\n    \"dateWorked\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultTimeEntryModelTimeEntry>(exampleJson)
            : default(QueryActionResultTimeEntryModelTimeEntry);
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
        [Route("/ATServicesRest/V1.0/TimeEntries/query/count")]
        [ValidateModelState]
        [SwaggerOperation("TimeEntriesUrlParameterQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult TimeEntriesUrlParameterQueryCount([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
