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
    public class AttachmentNestedAttachmentsChildApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="restModelInput"></param>
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/ATServicesRest/V1.0/Attachments/{parentId}/NestedAttachments")]
        [ValidateModelState]
        [SwaggerOperation("AttachmentNestedAttachmentsChildCreateEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult AttachmentNestedAttachmentsChildCreateEntity([FromBody]AttachmentNestedAttachmentModel restModelInput, [FromRoute][Required]long? parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("/ATServicesRest/V1.0/Attachments/{parentId}/NestedAttachments/{id}")]
        [ValidateModelState]
        [SwaggerOperation("AttachmentNestedAttachmentsChildDeleteEntity")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResultModel), description: "OK")]
        public virtual IActionResult AttachmentNestedAttachmentsChildDeleteEntity([FromRoute][Required]long? id, [FromRoute][Required]long? parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
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
        [Route("/ATServicesRest/V1.0/Attachments/{parentId}/NestedAttachments")]
        [ValidateModelState]
        [SwaggerOperation("AttachmentNestedAttachmentsChildQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(AttachmentNestedAttachmentModel), description: "OK")]
        public virtual IActionResult AttachmentNestedAttachmentsChildQuery([FromRoute][Required]long? parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AttachmentNestedAttachmentModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"fullPath\" : \"fullPath\",\n  \"impersonatorCreatorResourceID\" : 2,\n  \"creatorType\" : 5,\n  \"data\" : \"data\",\n  \"attachmentType\" : \"attachmentType\",\n  \"soapParentPropertyId\" : {\n    \"canReduce\" : true,\n    \"name\" : \"name\",\n    \"type\" : \"type\",\n    \"nodeType\" : \"Add\",\n    \"body\" : {\n      \"canReduce\" : true,\n      \"nodeType\" : \"Add\",\n      \"type\" : \"type\"\n    },\n    \"parameters\" : [ {\n      \"canReduce\" : true,\n      \"isByRef\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\"\n    }, {\n      \"canReduce\" : true,\n      \"isByRef\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\"\n    } ],\n    \"tailCall\" : true,\n    \"returnType\" : \"returnType\"\n  },\n  \"title\" : \"title\",\n  \"attachedByContactID\" : 6,\n  \"parentID\" : 9,\n  \"parentType\" : 2,\n  \"isTaskAttachment\" : true,\n  \"opportunityID\" : 7,\n  \"fileSize\" : 5.637376656633329,\n  \"attachDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"publish\" : 3,\n  \"id\" : 0,\n  \"contentType\" : \"contentType\",\n  \"attachedByResourceID\" : 1\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AttachmentNestedAttachmentModel>(exampleJson)
            : default(AttachmentNestedAttachmentModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/ATServicesRest/V1.0/Attachments/{parentId}/NestedAttachments/{id}")]
        [ValidateModelState]
        [SwaggerOperation("AttachmentNestedAttachmentsChildQueryItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(AttachmentNestedAttachmentModel), description: "OK")]
        public virtual IActionResult AttachmentNestedAttachmentsChildQueryItem([FromRoute][Required]long? id, [FromRoute][Required]long? parentId, [FromHeader][Required()]string apiIntegrationCode, [FromHeader][Required()]string userName, [FromHeader][Required()]string secret, [FromHeader]string impersonationResourceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AttachmentNestedAttachmentModel));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"fullPath\" : \"fullPath\",\n  \"impersonatorCreatorResourceID\" : 2,\n  \"creatorType\" : 5,\n  \"data\" : \"data\",\n  \"attachmentType\" : \"attachmentType\",\n  \"soapParentPropertyId\" : {\n    \"canReduce\" : true,\n    \"name\" : \"name\",\n    \"type\" : \"type\",\n    \"nodeType\" : \"Add\",\n    \"body\" : {\n      \"canReduce\" : true,\n      \"nodeType\" : \"Add\",\n      \"type\" : \"type\"\n    },\n    \"parameters\" : [ {\n      \"canReduce\" : true,\n      \"isByRef\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\"\n    }, {\n      \"canReduce\" : true,\n      \"isByRef\" : true,\n      \"name\" : \"name\",\n      \"type\" : \"type\",\n      \"nodeType\" : \"Add\"\n    } ],\n    \"tailCall\" : true,\n    \"returnType\" : \"returnType\"\n  },\n  \"title\" : \"title\",\n  \"attachedByContactID\" : 6,\n  \"parentID\" : 9,\n  \"parentType\" : 2,\n  \"isTaskAttachment\" : true,\n  \"opportunityID\" : 7,\n  \"fileSize\" : 5.637376656633329,\n  \"attachDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"publish\" : 3,\n  \"id\" : 0,\n  \"contentType\" : \"contentType\",\n  \"attachedByResourceID\" : 1\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AttachmentNestedAttachmentModel>(exampleJson)
            : default(AttachmentNestedAttachmentModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}