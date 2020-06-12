// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of a single parameter for an entity.
    /// </summary>
    public partial class GlobalParameterSpecification
    {
        /// <summary>
        /// Initializes a new instance of the GlobalParameterSpecification
        /// class.
        /// </summary>
        public GlobalParameterSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GlobalParameterSpecification
        /// class.
        /// </summary>
        /// <param name="type">Global Parameter type. Possible values include:
        /// 'Object', 'String', 'Int', 'Float', 'Bool', 'Array'</param>
        /// <param name="value">Value of parameter.</param>
        public GlobalParameterSpecification(string type, object value)
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets global Parameter type. Possible values include:
        /// 'Object', 'String', 'Int', 'Float', 'Bool', 'Array'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}