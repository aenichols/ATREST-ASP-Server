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
    public class ResourcesApiController : ControllerBase
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
        [HttpPatch]
        [Route("/ATServicesRest/V1.0/Resources")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesPatchEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult ResourcesPatchEntity([FromBody]ResourceModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Resources/query")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultResourceModelResource), description: "OK")]
        public virtual IActionResult ResourcesQuery([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultResourceModelResource));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"lastName\" : \"lastName\",\n    \"gender\" : \"gender\",\n    \"dateFormat\" : \"dateFormat\",\n    \"payrollType\" : 7,\n    \"greeting\" : 1,\n    \"isActive\" : true,\n    \"suffix\" : 9,\n    \"title\" : \"title\",\n    \"accountingReferenceID\" : \"accountingReferenceID\",\n    \"officeExtension\" : \"officeExtension\",\n    \"email3\" : \"email3\",\n    \"email2\" : \"email2\",\n    \"licenseType\" : 5,\n    \"numberFormat\" : \"numberFormat\",\n    \"officePhone\" : \"officePhone\",\n    \"id\" : 0,\n    \"email\" : \"email\",\n    \"internalCost\" : 5.962133916683182,\n    \"hireDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"defaultServiceDeskRoleID\" : 6,\n    \"initials\" : \"initials\",\n    \"homePhone\" : \"homePhone\",\n    \"userName\" : \"userName\",\n    \"emailTypeCode3\" : \"emailTypeCode3\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"firstName\" : \"firstName\",\n    \"emailTypeCode2\" : \"emailTypeCode2\",\n    \"mobilePhone\" : \"mobilePhone\",\n    \"locationID\" : 2,\n    \"timeFormat\" : \"timeFormat\",\n    \"travelAvailabilityPct\" : \"travelAvailabilityPct\",\n    \"middleName\" : \"middleName\",\n    \"userType\" : 2,\n    \"surveyResourceRating\" : 3.616076749251911,\n    \"emailTypeCode\" : \"emailTypeCode\",\n    \"resourceType\" : \"resourceType\"\n  }, {\n    \"lastName\" : \"lastName\",\n    \"gender\" : \"gender\",\n    \"dateFormat\" : \"dateFormat\",\n    \"payrollType\" : 7,\n    \"greeting\" : 1,\n    \"isActive\" : true,\n    \"suffix\" : 9,\n    \"title\" : \"title\",\n    \"accountingReferenceID\" : \"accountingReferenceID\",\n    \"officeExtension\" : \"officeExtension\",\n    \"email3\" : \"email3\",\n    \"email2\" : \"email2\",\n    \"licenseType\" : 5,\n    \"numberFormat\" : \"numberFormat\",\n    \"officePhone\" : \"officePhone\",\n    \"id\" : 0,\n    \"email\" : \"email\",\n    \"internalCost\" : 5.962133916683182,\n    \"hireDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"defaultServiceDeskRoleID\" : 6,\n    \"initials\" : \"initials\",\n    \"homePhone\" : \"homePhone\",\n    \"userName\" : \"userName\",\n    \"emailTypeCode3\" : \"emailTypeCode3\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"firstName\" : \"firstName\",\n    \"emailTypeCode2\" : \"emailTypeCode2\",\n    \"mobilePhone\" : \"mobilePhone\",\n    \"locationID\" : 2,\n    \"timeFormat\" : \"timeFormat\",\n    \"travelAvailabilityPct\" : \"travelAvailabilityPct\",\n    \"middleName\" : \"middleName\",\n    \"userType\" : 2,\n    \"surveyResourceRating\" : 3.616076749251911,\n    \"emailTypeCode\" : \"emailTypeCode\",\n    \"resourceType\" : \"resourceType\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultResourceModelResource>(exampleJson)
            : default(QueryActionResultResourceModelResource);
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
        [Route("/ATServicesRest/V1.0/Resources/query/count")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult ResourcesQueryCount([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Resources/entityInformation")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(EntityInformationResultModel), description: "OK")]
        public virtual IActionResult ResourcesQueryEntityInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Resources/entityInformation/fields")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesQueryFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(FieldInformationResultModel), description: "OK")]
        public virtual IActionResult ResourcesQueryFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Resources/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ItemQueryResultModelResourceModelResource), description: "OK")]
        public virtual IActionResult ResourcesQueryItem([FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ItemQueryResultModelResourceModelResource));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"item\" : {\n    \"lastName\" : \"lastName\",\n    \"gender\" : \"gender\",\n    \"dateFormat\" : \"dateFormat\",\n    \"payrollType\" : 7,\n    \"greeting\" : 1,\n    \"isActive\" : true,\n    \"suffix\" : 9,\n    \"title\" : \"title\",\n    \"accountingReferenceID\" : \"accountingReferenceID\",\n    \"officeExtension\" : \"officeExtension\",\n    \"email3\" : \"email3\",\n    \"email2\" : \"email2\",\n    \"licenseType\" : 5,\n    \"numberFormat\" : \"numberFormat\",\n    \"officePhone\" : \"officePhone\",\n    \"id\" : 0,\n    \"email\" : \"email\",\n    \"internalCost\" : 5.962133916683182,\n    \"hireDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"defaultServiceDeskRoleID\" : 6,\n    \"initials\" : \"initials\",\n    \"homePhone\" : \"homePhone\",\n    \"userName\" : \"userName\",\n    \"emailTypeCode3\" : \"emailTypeCode3\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"firstName\" : \"firstName\",\n    \"emailTypeCode2\" : \"emailTypeCode2\",\n    \"mobilePhone\" : \"mobilePhone\",\n    \"locationID\" : 2,\n    \"timeFormat\" : \"timeFormat\",\n    \"travelAvailabilityPct\" : \"travelAvailabilityPct\",\n    \"middleName\" : \"middleName\",\n    \"userType\" : 2,\n    \"surveyResourceRating\" : 3.616076749251911,\n    \"emailTypeCode\" : \"emailTypeCode\",\n    \"resourceType\" : \"resourceType\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemQueryResultModelResourceModelResource>(exampleJson)
            : default(ItemQueryResultModelResourceModelResource);
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
        [Route("/ATServicesRest/V1.0/Resources/entityInformation/userDefinedFields")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesQueryUserDefinedFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserDefinedFieldInformationResultModel), description: "OK")]
        public virtual IActionResult ResourcesQueryUserDefinedFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Resources")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesUpdateEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult ResourcesUpdateEntity([FromBody]ResourceModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Resources/query")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesUrlParameterQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultResourceModelResource), description: "OK")]
        public virtual IActionResult ResourcesUrlParameterQuery([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultResourceModelResource));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"lastName\" : \"lastName\",\n    \"gender\" : \"gender\",\n    \"dateFormat\" : \"dateFormat\",\n    \"payrollType\" : 7,\n    \"greeting\" : 1,\n    \"isActive\" : true,\n    \"suffix\" : 9,\n    \"title\" : \"title\",\n    \"accountingReferenceID\" : \"accountingReferenceID\",\n    \"officeExtension\" : \"officeExtension\",\n    \"email3\" : \"email3\",\n    \"email2\" : \"email2\",\n    \"licenseType\" : 5,\n    \"numberFormat\" : \"numberFormat\",\n    \"officePhone\" : \"officePhone\",\n    \"id\" : 0,\n    \"email\" : \"email\",\n    \"internalCost\" : 5.962133916683182,\n    \"hireDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"defaultServiceDeskRoleID\" : 6,\n    \"initials\" : \"initials\",\n    \"homePhone\" : \"homePhone\",\n    \"userName\" : \"userName\",\n    \"emailTypeCode3\" : \"emailTypeCode3\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"firstName\" : \"firstName\",\n    \"emailTypeCode2\" : \"emailTypeCode2\",\n    \"mobilePhone\" : \"mobilePhone\",\n    \"locationID\" : 2,\n    \"timeFormat\" : \"timeFormat\",\n    \"travelAvailabilityPct\" : \"travelAvailabilityPct\",\n    \"middleName\" : \"middleName\",\n    \"userType\" : 2,\n    \"surveyResourceRating\" : 3.616076749251911,\n    \"emailTypeCode\" : \"emailTypeCode\",\n    \"resourceType\" : \"resourceType\"\n  }, {\n    \"lastName\" : \"lastName\",\n    \"gender\" : \"gender\",\n    \"dateFormat\" : \"dateFormat\",\n    \"payrollType\" : 7,\n    \"greeting\" : 1,\n    \"isActive\" : true,\n    \"suffix\" : 9,\n    \"title\" : \"title\",\n    \"accountingReferenceID\" : \"accountingReferenceID\",\n    \"officeExtension\" : \"officeExtension\",\n    \"email3\" : \"email3\",\n    \"email2\" : \"email2\",\n    \"licenseType\" : 5,\n    \"numberFormat\" : \"numberFormat\",\n    \"officePhone\" : \"officePhone\",\n    \"id\" : 0,\n    \"email\" : \"email\",\n    \"internalCost\" : 5.962133916683182,\n    \"hireDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"defaultServiceDeskRoleID\" : 6,\n    \"initials\" : \"initials\",\n    \"homePhone\" : \"homePhone\",\n    \"userName\" : \"userName\",\n    \"emailTypeCode3\" : \"emailTypeCode3\",\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"firstName\" : \"firstName\",\n    \"emailTypeCode2\" : \"emailTypeCode2\",\n    \"mobilePhone\" : \"mobilePhone\",\n    \"locationID\" : 2,\n    \"timeFormat\" : \"timeFormat\",\n    \"travelAvailabilityPct\" : \"travelAvailabilityPct\",\n    \"middleName\" : \"middleName\",\n    \"userType\" : 2,\n    \"surveyResourceRating\" : 3.616076749251911,\n    \"emailTypeCode\" : \"emailTypeCode\",\n    \"resourceType\" : \"resourceType\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultResourceModelResource>(exampleJson)
            : default(QueryActionResultResourceModelResource);
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
        [Route("/ATServicesRest/V1.0/Resources/query/count")]
        [ValidateModelState]
        [SwaggerOperation("ResourcesUrlParameterQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult ResourcesUrlParameterQueryCount([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
