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
    public class ConfigurationItemNotesApiController : ControllerBase
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/query")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultConfigurationItemNoteModelInstalledProductNote), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesQuery([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultConfigurationItemNoteModelInstalledProductNote));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"impersonatorCreatorResourceID\" : 5,\n    \"noteType\" : 2,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"configurationItemID\" : 6,\n    \"description\" : \"description\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"impersonatorUpdaterResourceID\" : 5,\n    \"title\" : \"title\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"creatorResourceID\" : 1,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  }, {\n    \"impersonatorCreatorResourceID\" : 5,\n    \"noteType\" : 2,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"configurationItemID\" : 6,\n    \"description\" : \"description\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"impersonatorUpdaterResourceID\" : 5,\n    \"title\" : \"title\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"creatorResourceID\" : 1,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultConfigurationItemNoteModelInstalledProductNote>(exampleJson)
            : default(QueryActionResultConfigurationItemNoteModelInstalledProductNote);
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/query/count")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesQueryCount([FromBody]QueryModel queryModel, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/entityInformation")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(EntityInformationResultModel), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesQueryEntityInformation([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/entityInformation/fields")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesQueryFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(FieldInformationResultModel), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesQueryFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ItemQueryResultModelConfigurationItemNoteModelInstalledProductNote), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesQueryItem([FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ItemQueryResultModelConfigurationItemNoteModelInstalledProductNote));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"item\" : {\n    \"impersonatorCreatorResourceID\" : 5,\n    \"noteType\" : 2,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"configurationItemID\" : 6,\n    \"description\" : \"description\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"impersonatorUpdaterResourceID\" : 5,\n    \"title\" : \"title\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"creatorResourceID\" : 1,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemQueryResultModelConfigurationItemNoteModelInstalledProductNote>(exampleJson)
            : default(ItemQueryResultModelConfigurationItemNoteModelInstalledProductNote);
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/entityInformation/userDefinedFields")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesQueryUserDefinedFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserDefinedFieldInformationResultModel), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesQueryUserDefinedFieldDefinitions([FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/query")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesUrlParameterQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultConfigurationItemNoteModelInstalledProductNote), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesUrlParameterQuery([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultConfigurationItemNoteModelInstalledProductNote));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"impersonatorCreatorResourceID\" : 5,\n    \"noteType\" : 2,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"configurationItemID\" : 6,\n    \"description\" : \"description\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"impersonatorUpdaterResourceID\" : 5,\n    \"title\" : \"title\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"creatorResourceID\" : 1,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  }, {\n    \"impersonatorCreatorResourceID\" : 5,\n    \"noteType\" : 2,\n    \"lastActivityDate\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"configurationItemID\" : 6,\n    \"description\" : \"description\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"impersonatorUpdaterResourceID\" : 5,\n    \"title\" : \"title\",\n    \"createDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"creatorResourceID\" : 1,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultConfigurationItemNoteModelInstalledProductNote>(exampleJson)
            : default(QueryActionResultConfigurationItemNoteModelInstalledProductNote);
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
        [Route("/ATServicesRest/V1.0/ConfigurationItemNotes/query/count")]
        [ValidateModelState]
        [SwaggerOperation("ConfigurationItemNotesUrlParameterQueryCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryCountResultModel), description: "OK")]
        public virtual IActionResult ConfigurationItemNotesUrlParameterQueryCount([FromQuery][Required()]string search, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
