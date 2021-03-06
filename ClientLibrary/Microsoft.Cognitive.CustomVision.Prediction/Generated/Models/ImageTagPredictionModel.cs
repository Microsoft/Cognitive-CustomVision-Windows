// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Cognitive.CustomVision.Prediction.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ImageTagPredictionModel
    {
        /// <summary>
        /// Initializes a new instance of the ImageTagPredictionModel class.
        /// </summary>
        public ImageTagPredictionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageTagPredictionModel class.
        /// </summary>
        public ImageTagPredictionModel(System.Guid tagId = default(System.Guid), string tag = default(string), double probability = default(double))
        {
            TagId = tagId;
            Tag = tag;
            Probability = probability;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TagId")]
        public System.Guid TagId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Tag")]
        public string Tag { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Probability")]
        public double Probability { get; private set; }

    }
}
