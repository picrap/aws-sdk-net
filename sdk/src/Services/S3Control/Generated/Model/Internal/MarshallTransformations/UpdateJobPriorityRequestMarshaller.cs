/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateJobPriority Request Marshaller
    /// </summary>       
    public class UpdateJobPriorityRequestMarshaller : IMarshaller<IRequest, UpdateJobPriorityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobPriorityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobPriorityRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "POST";
            string uriResourcePath = "/v20180820/jobs/{id}/priority";
        
            if(publicRequest.IsSetAccountId())
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            if (!publicRequest.IsSetJobId())
                throw new AmazonS3ControlException("Request object does not have required field JobId set");
            uriResourcePath = uriResourcePath.Replace("{id}", StringUtils.FromStringWithSlashEncoding(publicRequest.JobId));
            
            if (publicRequest.IsSetPriority())
                request.Parameters.Add("priority", StringUtils.FromInt(publicRequest.Priority));
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }
        private static UpdateJobPriorityRequestMarshaller _instance = new UpdateJobPriorityRequestMarshaller();        

        internal static UpdateJobPriorityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobPriorityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}