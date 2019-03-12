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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteTable operation.
    /// Deletes multiple tables at once.
    /// 
    ///  <note> 
    /// <para>
    /// After completing this operation, you will no longer have access to the table versions
    /// and partitions that belong to the deleted table. AWS Glue deletes these "orphaned"
    /// resources asynchronously in a timely manner, at the discretion of the service.
    /// </para>
    ///  
    /// <para>
    /// To ensure immediate deletion of all related resources, before calling <code>BatchDeleteTable</code>,
    /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, and <code>DeletePartition</code>
    /// or <code>BatchDeletePartition</code>, to delete any resources that belong to the table.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchDeleteTableRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private List<string> _tablesToDelete = new List<string>();

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the AWS account
        /// ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database where the tables to delete reside. For Hive compatibility,
        /// this name is entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TablesToDelete. 
        /// <para>
        /// A list of the table to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> TablesToDelete
        {
            get { return this._tablesToDelete; }
            set { this._tablesToDelete = value; }
        }

        // Check to see if TablesToDelete property is set
        internal bool IsSetTablesToDelete()
        {
            return this._tablesToDelete != null && this._tablesToDelete.Count > 0; 
        }

    }
}