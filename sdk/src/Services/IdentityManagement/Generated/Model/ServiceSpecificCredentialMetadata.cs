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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains additional details about a service-specific credential.
    /// </summary>
    public partial class ServiceSpecificCredentialMetadata
    {
        private DateTime? _createDate;
        private string _serviceName;
        private string _serviceSpecificCredentialId;
        private string _serviceUserName;
        private StatusType _status;
        private string _userName;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the service-specific credential were created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service associated with the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSpecificCredentialId. 
        /// <para>
        /// The unique identifier for the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string ServiceSpecificCredentialId
        {
            get { return this._serviceSpecificCredentialId; }
            set { this._serviceSpecificCredentialId = value; }
        }

        // Check to see if ServiceSpecificCredentialId property is set
        internal bool IsSetServiceSpecificCredentialId()
        {
            return this._serviceSpecificCredentialId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUserName. 
        /// <para>
        /// The generated user name for the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=200)]
        public string ServiceUserName
        {
            get { return this._serviceUserName; }
            set { this._serviceUserName = value; }
        }

        // Check to see if ServiceUserName property is set
        internal bool IsSetServiceUserName()
        {
            return this._serviceUserName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service-specific credential. <code>Active</code> means that the
        /// key is valid for API calls, while <code>Inactive</code> means it is not.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user associated with the service-specific credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}