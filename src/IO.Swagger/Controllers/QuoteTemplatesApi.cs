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
    public class QuoteTemplatesApiController : ControllerBase
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/query")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultQuoteTemplateModelQuoteTemplate), description: "OK")]
        public virtual IActionResult QuoteTemplatesQuery([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultQuoteTemplateModelQuoteTemplate));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"currencyNegativeFormat\" : \"currencyNegativeFormat\",\n    \"pageLayout\" : 2,\n    \"dateFormat\" : 1,\n    \"description\" : \"description\",\n    \"isActive\" : true,\n    \"lastActivityBy\" : 5,\n    \"pageNumberFormat\" : 7,\n    \"displayTaxCategorySuperscripts\" : true,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"currencyPositiveFormat\" : \"currencyPositiveFormat\",\n    \"calculateTaxSeparately\" : true,\n    \"showTaxCategory\" : true,\n    \"showEachTaxInGroup\" : true,\n    \"numberFormat\" : 5,\n    \"createdBy\" : 6,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"name\" : \"name\",\n    \"showVerticalGridLines\" : true,\n    \"id\" : 0,\n    \"showGridHeader\" : true,\n    \"createDate\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"currencyNegativeFormat\" : \"currencyNegativeFormat\",\n    \"pageLayout\" : 2,\n    \"dateFormat\" : 1,\n    \"description\" : \"description\",\n    \"isActive\" : true,\n    \"lastActivityBy\" : 5,\n    \"pageNumberFormat\" : 7,\n    \"displayTaxCategorySuperscripts\" : true,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"currencyPositiveFormat\" : \"currencyPositiveFormat\",\n    \"calculateTaxSeparately\" : true,\n    \"showTaxCategory\" : true,\n    \"showEachTaxInGroup\" : true,\n    \"numberFormat\" : 5,\n    \"createdBy\" : 6,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"name\" : \"name\",\n    \"showVerticalGridLines\" : true,\n    \"id\" : 0,\n    \"showGridHeader\" : true,\n    \"createDate\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultQuoteTemplateModelQuoteTemplate>(exampleJson)
            : default(QueryActionResultQuoteTemplateModelQuoteTemplate);
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/query/count")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult QuoteTemplatesQueryCount([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/entityInformation")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(EntityInformationResultModel), description: "OK")]
        public virtual IActionResult QuoteTemplatesQueryEntityInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/entityInformation/fields")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesQueryFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(FieldInformationResultModel), description: "OK")]
        public virtual IActionResult QuoteTemplatesQueryFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/{id}")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ItemQueryResultModelQuoteTemplateModelQuoteTemplate), description: "OK")]
        public virtual IActionResult QuoteTemplatesQueryItem([FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ItemQueryResultModelQuoteTemplateModelQuoteTemplate));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"item\" : {\n    \"currencyNegativeFormat\" : \"currencyNegativeFormat\",\n    \"pageLayout\" : 2,\n    \"dateFormat\" : 1,\n    \"description\" : \"description\",\n    \"isActive\" : true,\n    \"lastActivityBy\" : 5,\n    \"pageNumberFormat\" : 7,\n    \"displayTaxCategorySuperscripts\" : true,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"currencyPositiveFormat\" : \"currencyPositiveFormat\",\n    \"calculateTaxSeparately\" : true,\n    \"showTaxCategory\" : true,\n    \"showEachTaxInGroup\" : true,\n    \"numberFormat\" : 5,\n    \"createdBy\" : 6,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"name\" : \"name\",\n    \"showVerticalGridLines\" : true,\n    \"id\" : 0,\n    \"showGridHeader\" : true,\n    \"createDate\" : \"2000-01-23T04:56:07.000+00:00\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemQueryResultModelQuoteTemplateModelQuoteTemplate>(exampleJson)
            : default(ItemQueryResultModelQuoteTemplateModelQuoteTemplate);
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/entityInformation/userDefinedFields")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesQueryUserDefinedFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserDefinedFieldInformationResultModel), description: "OK")]
        public virtual IActionResult QuoteTemplatesQueryUserDefinedFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/query")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesUrlParameterQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultQuoteTemplateModelQuoteTemplate), description: "OK")]
        public virtual IActionResult QuoteTemplatesUrlParameterQuery([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultQuoteTemplateModelQuoteTemplate));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"currencyNegativeFormat\" : \"currencyNegativeFormat\",\n    \"pageLayout\" : 2,\n    \"dateFormat\" : 1,\n    \"description\" : \"description\",\n    \"isActive\" : true,\n    \"lastActivityBy\" : 5,\n    \"pageNumberFormat\" : 7,\n    \"displayTaxCategorySuperscripts\" : true,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"currencyPositiveFormat\" : \"currencyPositiveFormat\",\n    \"calculateTaxSeparately\" : true,\n    \"showTaxCategory\" : true,\n    \"showEachTaxInGroup\" : true,\n    \"numberFormat\" : 5,\n    \"createdBy\" : 6,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"name\" : \"name\",\n    \"showVerticalGridLines\" : true,\n    \"id\" : 0,\n    \"showGridHeader\" : true,\n    \"createDate\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"currencyNegativeFormat\" : \"currencyNegativeFormat\",\n    \"pageLayout\" : 2,\n    \"dateFormat\" : 1,\n    \"description\" : \"description\",\n    \"isActive\" : true,\n    \"lastActivityBy\" : 5,\n    \"pageNumberFormat\" : 7,\n    \"displayTaxCategorySuperscripts\" : true,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ],\n    \"currencyPositiveFormat\" : \"currencyPositiveFormat\",\n    \"calculateTaxSeparately\" : true,\n    \"showTaxCategory\" : true,\n    \"showEachTaxInGroup\" : true,\n    \"numberFormat\" : 5,\n    \"createdBy\" : 6,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"name\" : \"name\",\n    \"showVerticalGridLines\" : true,\n    \"id\" : 0,\n    \"showGridHeader\" : true,\n    \"createDate\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultQuoteTemplateModelQuoteTemplate>(exampleJson)
            : default(QueryActionResultQuoteTemplateModelQuoteTemplate);
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
        [Route("/ATServicesRest/V1.0/QuoteTemplates/query/count")]
        [ValidateModelState]
        [SwaggerOperation("QuoteTemplatesUrlParameterQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult QuoteTemplatesUrlParameterQueryCount([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
