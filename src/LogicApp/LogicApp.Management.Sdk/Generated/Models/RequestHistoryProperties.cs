// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The request history.
    /// </summary>
    public partial class RequestHistoryProperties
    {
        /// <summary>
        /// Initializes a new instance of the RequestHistoryProperties class.
        /// </summary>
        public RequestHistoryProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequestHistoryProperties class.
        /// </summary>

        /// <param name="startTime">The time the request started.
        /// </param>

        /// <param name="endTime">The time the request ended.
        /// </param>

        /// <param name="request">The request.
        /// </param>

        /// <param name="response">The response.
        /// </param>
        public RequestHistoryProperties(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), Request request = default(Request), Response response = default(Response))

        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Request = request;
            this.Response = response;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the time the request started.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime {get; set; }

        /// <summary>
        /// Gets or sets the time the request ended.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime {get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "request")]
        public Request Request {get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "response")]
        public Response Response {get; set; }
    }
}