// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The number of nodes in each state for a pool.
    /// </summary>
    public partial class PoolNodeCounts
    {
        /// <summary>
        /// Initializes a new instance of the PoolNodeCounts class.
        /// </summary>
        public PoolNodeCounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolNodeCounts class.
        /// </summary>
        /// <param name="poolId">The ID of the pool.</param>
        /// <param name="dedicated">The number of dedicated nodes in each
        /// state.</param>
        /// <param name="lowPriority">The number of low priority nodes in each
        /// state.</param>
        public PoolNodeCounts(string poolId, NodeCounts dedicated = default(NodeCounts), NodeCounts lowPriority = default(NodeCounts))
        {
            PoolId = poolId;
            Dedicated = dedicated;
            LowPriority = lowPriority;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets the number of dedicated nodes in each state.
        /// </summary>
        [JsonProperty(PropertyName = "dedicated")]
        public NodeCounts Dedicated { get; set; }

        /// <summary>
        /// Gets or sets the number of low priority nodes in each state.
        /// </summary>
        [JsonProperty(PropertyName = "lowPriority")]
        public NodeCounts LowPriority { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PoolId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PoolId");
            }
            if (Dedicated != null)
            {
                Dedicated.Validate();
            }
            if (LowPriority != null)
            {
                LowPriority.Validate();
            }
        }
    }
}