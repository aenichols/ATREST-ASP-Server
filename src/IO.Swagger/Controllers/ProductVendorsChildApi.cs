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
    public class ProductVendorsChildApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="parentId"></param>
        /// <param name="restModelInput"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildCreateEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult ProductVendorsChildCreateEntity([FromRoute][Required]long? parentId, [FromBody]ProductVendorModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        
        /// <param name="parentId"></param>
        /// <param name="restModelInput"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPatch]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildPatchEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult ProductVendorsChildPatchEntity([FromRoute][Required]long? parentId, [FromBody]ProductVendorModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryActionResultProductVendorModelProductVendor), description: "OK")]
        public virtual IActionResult ProductVendorsChildQuery([FromRoute][Required]long? parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryActionResultProductVendorModelProductVendor));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"pageDetails\" : {\n    \"requestCount\" : 5,\n    \"nextPageUrl\" : \"nextPageUrl\",\n    \"count\" : 1,\n    \"prevPageUrl\" : \"prevPageUrl\"\n  },\n  \"items\" : [ {\n    \"isDefault\" : true,\n    \"productID\" : 6,\n    \"vendorID\" : 5,\n    \"vendorPartNumber\" : \"vendorPartNumber\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"isActive\" : true,\n    \"vendorCost\" : 1.4658129805029452,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  }, {\n    \"isDefault\" : true,\n    \"productID\" : 6,\n    \"vendorID\" : 5,\n    \"vendorPartNumber\" : \"vendorPartNumber\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"isActive\" : true,\n    \"vendorCost\" : 1.4658129805029452,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryActionResultProductVendorModelProductVendor>(exampleJson)
            : default(QueryActionResultProductVendorModelProductVendor);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors/entityInformation")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildQueryEntityInformation")]
        [SwaggerResponse(statusCode: 200, type: typeof(EntityInformationResultModel), description: "OK")]
        public virtual IActionResult ProductVendorsChildQueryEntityInformation([FromRoute][Required]string parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors/entityInformation/fields")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildQueryFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(FieldInformationResultModel), description: "OK")]
        public virtual IActionResult ProductVendorsChildQueryFieldDefinitions([FromRoute][Required]string parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        
        /// <param name="parentId"></param>
        /// <param name="id"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(ItemQueryResultModelProductVendorModelProductVendor), description: "OK")]
        public virtual IActionResult ProductVendorsChildQueryItem([FromRoute][Required]long? parentId, [FromRoute][Required]long? id, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ItemQueryResultModelProductVendorModelProductVendor));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"item\" : {\n    \"isDefault\" : true,\n    \"productID\" : 6,\n    \"vendorID\" : 5,\n    \"vendorPartNumber\" : \"vendorPartNumber\",\n    \"soapParentPropertyId\" : {\n      \"canReduce\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\",\n      \"body\" : {\n        \"canReduce\" : true,\n        \"nodeType\" : \"Add\",\n        \"type\" : \"type\"\n      },\n      \"parameters\" : [ {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      }, {\n        \"canReduce\" : true,\n        \"isByRef\" : true,\n        \"name\" : \"name\",\n        \"type\" : \"type\",\n        \"nodeType\" : \"Add\"\n      } ],\n      \"tailCall\" : true,\n      \"returnType\" : \"returnType\"\n    },\n    \"id\" : 0,\n    \"isActive\" : true,\n    \"vendorCost\" : 1.4658129805029452,\n    \"userDefinedFields\" : [ {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    }, {\n      \"name\" : \"name\",\n      \"value\" : \"value\"\n    } ]\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemQueryResultModelProductVendorModelProductVendor>(exampleJson)
            : default(ItemQueryResultModelProductVendorModelProductVendor);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors/entityInformation/userDefinedFields")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildQueryUserDefinedFieldDefinitions")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserDefinedFieldInformationResultModel), description: "OK")]
        public virtual IActionResult ProductVendorsChildQueryUserDefinedFieldDefinitions([FromRoute][Required]string parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        
        /// <param name="parentId"></param>
        /// <param name="restModelInput"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPut]
        [Route("/ATServicesRest/V1.0/Products/{parentId}/Vendors")]
        [ValidateModelState]
        [SwaggerOperation("ProductVendorsChildUpdateEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult ProductVendorsChildUpdateEntity([FromRoute][Required]long? parentId, [FromBody]ProductVendorModel restModelInput, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
    }
}