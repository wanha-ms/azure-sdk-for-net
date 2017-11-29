// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response body for identify face operation.
    /// </summary>
    public partial class IdentifyResultItem
    {
        /// <summary>
        /// Initializes a new instance of the IdentifyResultItem class.
        /// </summary>
        public IdentifyResultItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentifyResultItem class.
        /// </summary>
        /// <param name="faceId">faceId of the query face</param>
        public IdentifyResultItem(string faceId, IList<IdentifyResultCandidate> candidates)
        {
            FaceId = faceId;
            Candidates = candidates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets faceId of the query face
        /// </summary>
        [JsonProperty(PropertyName = "faceId")]
        public string FaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "candidates")]
        public IList<IdentifyResultCandidate> Candidates { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FaceId");
            }
            if (Candidates == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Candidates");
            }
            if (FaceId != null)
            {
                if (FaceId.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FaceId", 64);
                }
            }
            if (Candidates != null)
            {
                foreach (var element in Candidates)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}