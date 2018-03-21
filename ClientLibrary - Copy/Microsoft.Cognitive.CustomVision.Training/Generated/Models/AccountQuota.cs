// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Cognitive.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a set of quotas assocated with an account
    /// </summary>
    public partial class AccountQuota
    {
        /// <summary>
        /// Initializes a new instance of the AccountQuota class.
        /// </summary>
        public AccountQuota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountQuota class.
        /// </summary>
        /// <param name="tier">Gets the tier of user</param>
        /// <param name="projects">Gets the project quota</param>
        /// <param name="predictions">Gets the prediction quota</param>
        /// <param name="perProject">Gets a list of quotas that apply
        /// per-project for each project</param>
        public AccountQuota(string tier = default(string), Quota projects = default(Quota), Quota predictions = default(Quota), IList<PerProjectQuota> perProject = default(IList<PerProjectQuota>))
        {
            Tier = tier;
            Projects = projects;
            Predictions = predictions;
            PerProject = perProject;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the tier of user
        /// </summary>
        [JsonProperty(PropertyName = "Tier")]
        public string Tier { get; private set; }

        /// <summary>
        /// Gets the project quota
        /// </summary>
        [JsonProperty(PropertyName = "Projects")]
        public Quota Projects { get; private set; }

        /// <summary>
        /// Gets the prediction quota
        /// </summary>
        [JsonProperty(PropertyName = "Predictions")]
        public Quota Predictions { get; private set; }

        /// <summary>
        /// Gets a list of quotas that apply per-project for each project
        /// </summary>
        [JsonProperty(PropertyName = "PerProject")]
        public IList<PerProjectQuota> PerProject { get; private set; }

    }
}
