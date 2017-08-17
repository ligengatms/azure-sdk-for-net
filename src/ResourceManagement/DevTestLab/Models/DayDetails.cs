// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a daily schedule.
    /// </summary>
    public partial class DayDetails
    {
        /// <summary>
        /// Initializes a new instance of the DayDetails class.
        /// </summary>
        public DayDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DayDetails class.
        /// </summary>
        /// <param name="time">The time of day the schedule will occur.</param>
        public DayDetails(string time = default(string))
        {
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time of day the schedule will occur.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

    }
}