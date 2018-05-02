// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The results and errors from an execution of a pool autoscale formula.
    /// </summary>
    public partial class AutoScaleRun
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleRun class.
        /// </summary>
        public AutoScaleRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaleRun class.
        /// </summary>
        /// <param name="evaluationTime">The time at which the autoscale
        /// formula was last evaluated.</param>
        /// <param name="results">The final values of all variables used in the
        /// evaluation of the autoscale formula.</param>
        /// <param name="error">Details of the error encountered evaluating the
        /// autoscale formula on the pool, if the evaluation was
        /// unsuccessful.</param>
        public AutoScaleRun(System.DateTime evaluationTime, string results = default(string), AutoScaleRunError error = default(AutoScaleRunError))
        {
            EvaluationTime = evaluationTime;
            Results = results;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time at which the autoscale formula was last
        /// evaluated.
        /// </summary>
        [JsonProperty(PropertyName = "evaluationTime")]
        public System.DateTime EvaluationTime { get; set; }

        /// <summary>
        /// Gets or sets the final values of all variables used in the
        /// evaluation of the autoscale formula.
        /// </summary>
        /// <remarks>
        /// Each variable value is returned in the form $variable=value, and
        /// variables are separated by semicolons.
        /// </remarks>
        [JsonProperty(PropertyName = "results")]
        public string Results { get; set; }

        /// <summary>
        /// Gets or sets details of the error encountered evaluating the
        /// autoscale formula on the pool, if the evaluation was unsuccessful.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public AutoScaleRunError Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}
