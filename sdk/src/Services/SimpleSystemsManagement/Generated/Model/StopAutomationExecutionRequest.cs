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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the StopAutomationExecution operation.
    /// Stop an Automation that is currently executing.
    /// </summary>
    public partial class StopAutomationExecutionRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _automationExecutionId;
        private StopType _type;

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The execution ID of the Automation to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AutomationExecutionId
        {
            get { return this._automationExecutionId; }
            set { this._automationExecutionId = value; }
        }

        // Check to see if AutomationExecutionId property is set
        internal bool IsSetAutomationExecutionId()
        {
            return this._automationExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The stop request type. Valid types include the following: Cancel and Complete. The
        /// default type is Cancel.
        /// </para>
        /// </summary>
        public StopType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}