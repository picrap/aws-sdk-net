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
    /// Container for the parameters to the GetMaintenanceWindowExecutionTask operation.
    /// Retrieves the details about a specific task executed as part of a Maintenance Window
    /// execution.
    /// </summary>
    public partial class GetMaintenanceWindowExecutionTaskRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _taskId;
        private string _windowExecutionId;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the specific task execution in the Maintenance Window task that should be
        /// retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property WindowExecutionId. 
        /// <para>
        /// The ID of the Maintenance Window execution that includes the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WindowExecutionId
        {
            get { return this._windowExecutionId; }
            set { this._windowExecutionId = value; }
        }

        // Check to see if WindowExecutionId property is set
        internal bool IsSetWindowExecutionId()
        {
            return this._windowExecutionId != null;
        }

    }
}