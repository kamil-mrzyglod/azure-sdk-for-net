// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The estimated price info for using a VM. </summary>
    public partial class EstimatedVMPrices
    {
        /// <summary> Initializes a new instance of EstimatedVMPrices. </summary>
        /// <param name="billingCurrency"> Three lettered code specifying the currency of the VM price. Example: USD. </param>
        /// <param name="unitOfMeasure"> The unit of time measurement for the specified VM price. Example: OneHour. </param>
        /// <param name="values"> The list of estimated prices for using a VM of a particular OS type, tier, etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="values"/> is null. </exception>
        internal EstimatedVMPrices(BillingCurrency billingCurrency, UnitOfMeasure unitOfMeasure, IEnumerable<EstimatedVMPrice> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            BillingCurrency = billingCurrency;
            UnitOfMeasure = unitOfMeasure;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of EstimatedVMPrices. </summary>
        /// <param name="billingCurrency"> Three lettered code specifying the currency of the VM price. Example: USD. </param>
        /// <param name="unitOfMeasure"> The unit of time measurement for the specified VM price. Example: OneHour. </param>
        /// <param name="values"> The list of estimated prices for using a VM of a particular OS type, tier, etc. </param>
        internal EstimatedVMPrices(BillingCurrency billingCurrency, UnitOfMeasure unitOfMeasure, IReadOnlyList<EstimatedVMPrice> values)
        {
            BillingCurrency = billingCurrency;
            UnitOfMeasure = unitOfMeasure;
            Values = values;
        }

        /// <summary> Three lettered code specifying the currency of the VM price. Example: USD. </summary>
        public BillingCurrency BillingCurrency { get; }
        /// <summary> The unit of time measurement for the specified VM price. Example: OneHour. </summary>
        public UnitOfMeasure UnitOfMeasure { get; }
        /// <summary> The list of estimated prices for using a VM of a particular OS type, tier, etc. </summary>
        public IReadOnlyList<EstimatedVMPrice> Values { get; }
    }
}
